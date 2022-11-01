using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System;
using System.IdentityModel.Tokens.Jwt;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteDomain.Interfaces.Services
{
    public interface ITokenService
    {
        string GenerateToken(Conta user);
    }
}
