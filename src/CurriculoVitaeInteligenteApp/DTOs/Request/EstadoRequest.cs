using CurriculoVitaeInteligenteApp.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class EstadoRequest : BaseRequest
    {
        public Guid? Pais_Id { get; set; }
        public string? Nome { get; set; }
        public string? UF { get; set; }

    }
}
