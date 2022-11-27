using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Constant.settings;
using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Entities.Interfaces;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;

namespace CurriculoVitaeInteligenteApp.Services
{
    public abstract class BaseServiceApp<T> : IBaseServiceApp<T> where T : ClassBase, IAddContextBaseProperty
    {
        private readonly IBaseService<T> _Service;
        private readonly IMapper _mapper;
        protected readonly IUnitOfWork _unitOfWork;

        protected BaseServiceApp(IBaseService<T> Service, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _Service = Service;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public string GetClaimsFromToken(string token)
        {
            try
            {


                var tokenvalidationparametros = new TokenValidationParameters
                {
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Token.Secret)),
                    ValidateLifetime = false,
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var principal = tokenHandler.ValidateToken(token, tokenvalidationparametros, out var securityToken);
                if (securityToken is not JwtSecurityToken jwtSecurityToken)
                {

                }
                var contaId = principal.Claims.Where(p => p.Type == ClaimTypes.NameIdentifier).Select(c => c.Value).SingleOrDefault()!.ToString()!;

                return contaId;
            }
            catch (Exception)
            {
                throw ;
            }
        }


        public virtual async Task<T> Add(T TEntity, bool saveChanges = true)
        {
            return await _Service.Add(TEntity, saveChanges);
        }

        public virtual async Task<T?> Get(string id)
        {
            return await _Service.Get(id);
        }

        public virtual async Task<IList<T>> GetList(string ContaId = "")
        {
            return await _Service.GetList(ContaId);

        }

        public virtual async Task<bool> Remove(string id)
        {
            return await _Service.Remove(id);
        }

        public virtual async Task<T> Edit(string id, T TEntity)
        {
            try
            {
                TEntity = await _Service.Edit(id, TEntity);
                return TEntity;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public virtual async Task<T?> GetFirstOrDefault(Expression<Func<T, bool>>? condicao = null)
        {
            try
            {
                return await _Service.GetFirstOrDefault(condicao);
            }
            catch
            {
                return null;
            }
        }

        public virtual async Task<IList<T>?> GetToList(Expression<Func<T, bool>>? condicao = null)
        {
            try
            {
                return await _Service.GetToList(condicao);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }

}

