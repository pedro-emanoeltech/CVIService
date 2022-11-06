using CurriculoVitaeInteligenteApp.DTOs.Request;
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
        public Guid? VagaId { get; set; }

        public string? Email { get; set; }

        public string? Telefone { get; set; }

        public string? Celular { get; set; }

        public string? CelularSecundario { get; set; }

        //navegacao
        public virtual Perfil? Perfil { get; set; }

        public virtual VagaRequest? Vaga { get; set; }

        public virtual HistoricoProfissional? HistoricoProfissional { get; set; }
    }
}
