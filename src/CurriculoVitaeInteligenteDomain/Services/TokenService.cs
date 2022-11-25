using AutoMapper;
using CurriculoVitaeInteligenteDomain.Constant.settings;
using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CurriculoVitaeInteligenteDomain.Services
{
    public class TokenService :BaseService<TokenAuth> ,ITokenService
    {
        private readonly ITokenRepository _tokenRepository;
        private readonly IContaService _contaService;
        private readonly IMapper _mapper;

        public TokenService(ITokenRepository repository, IUnitOfWork unitOfWork, IContaService contaService, IMapper mapper) : base(repository, unitOfWork)
        {
            _tokenRepository = repository;
            _contaService = contaService;
            _mapper = mapper;
        }

        public async Task<TokenAuth?> GenerateToken(Conta user)
        {
            if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Senha))
            {
                return null;
            }
            try
            {
                var conta = await _contaService.GetFirstOrDefault(p => p.Email == user.Email && p.Senha == user.Senha);
                if (conta is null)
                {
                    return null;
                }

                var dataExpiracao = DateTime.UtcNow.AddMinutes(60);
                var key = Encoding.ASCII.GetBytes(Token.Secret);
                var claimsIdentity = new ClaimsIdentity(new List<Claim>

                {
                    new Claim(ClaimTypes.Email,conta.Email!),
                    new Claim(ClaimTypes.NameIdentifier,conta.Id.ToString()!),
                    new Claim(ClaimTypes.Role,conta.TipoConta.ToString()!)
                });
                var credencial = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature
                    );
                var Descriptor = new SecurityTokenDescriptor
                {
                    Subject = claimsIdentity,
                    Expires = dataExpiracao,
                    SigningCredentials = credencial
                };
                var jwtTokenHandler = new JwtSecurityTokenHandler();
                var securityToken = jwtTokenHandler.CreateToken(Descriptor);
                var tokenResult = jwtTokenHandler.WriteToken(securityToken);

                var tokenAuth = new TokenAuth
                {
                    Email = user.Email,
                    Role = user.TipoConta.ToString(),
                    Token = tokenResult,
                    DataExpiracao = dataExpiracao,
                    ExpiryTimeStamp = (int)dataExpiracao.Subtract(DateTime.UtcNow).TotalSeconds
                };
                _mapper.Map(conta, tokenAuth);
               

                await _tokenRepository.Add(tokenAuth!);
                return tokenAuth;

            }
            catch (Exception e)
            {
                throw new Exception("Erro ao fazer login" + e.Message);
            }
            
           
        }
    }

}
