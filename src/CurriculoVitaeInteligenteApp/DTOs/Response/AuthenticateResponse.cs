using CurriculoVitaeInteligenteDomain.Content.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public class AuthenticateResponse : BaseResponse
    {
        public Guid? ContaId { get; set; }
        public string? Email { get; set; }
        public string? Token { get; set; }

    }
}
