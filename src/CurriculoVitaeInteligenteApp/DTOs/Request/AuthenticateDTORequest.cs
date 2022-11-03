using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteApp.DTOs.Request
{
    public class AuthenticateDTORequest : BaseRequest
    {
        public string? Email { get; set; }

        public string? Senha { get; set; }
    }
}
