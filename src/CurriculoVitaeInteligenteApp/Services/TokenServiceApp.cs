using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Constant.settings;
using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;
using CVIServiceLibShared.App.Response;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CurriculoVitaeInteligenteApp.Services
{
    public class TokenServiceApp : BaseServiceApp<TokenAuth>, ITokenServiceApp
    {
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;
        public TokenServiceApp(ITokenService service, IUnitOfWork unitOfWork, IMapper mapper) : base(service, mapper, unitOfWork)
        {
            _tokenService = service;
            _mapper = mapper;
        }

        public async Task<AuthenticateResponse?> GenerateToken(Conta user)
        {
            var result = await _tokenService.GenerateToken(user);
            if (result is null)
            {
                return null;
            }
            var response = _mapper.Map<AuthenticateResponse>(result!);
            return response;
        }


    }
}
