using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteDomain.Content.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public class ContatoResponse : BaseResponse
    {
        public Guid? PerfilId { get; set; }
        public Guid? VagaId { get; set; }

        public TipoContato TipoContato { get; set; }
        public string? Texto { get; set; }
    }
}
