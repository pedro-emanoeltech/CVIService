using CurriculoVitaeInteligenteApp.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class NacionalidadeRequest : BaseRequest
    {
        public string? NomePais { get; set; }

    }
}
