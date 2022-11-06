using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteApp.DTOs.Request
{
    public class CandidaturaRequest : BaseRequest
    {
        public Guid? PerfilId { get; set; }
        public Guid? VagaId { get; set; }

        public virtual Vaga? Vaga { get; set; }
        public virtual Perfil? Perfil { get; set; }
    }
}
