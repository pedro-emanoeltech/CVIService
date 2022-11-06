using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteApp.DTOs.Request
{
    public class ContatoRequest : BaseRequest
    {
        public Guid? PerfilId { get; set; }

        public TipoContato TipoContato { get; set; }
        public string? Texto { get; set; }
    }
}
