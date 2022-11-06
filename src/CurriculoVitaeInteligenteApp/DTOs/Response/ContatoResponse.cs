using CurriculoVitaeInteligenteApp.DTOs.Response;
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

        public string? Email { get; set; }

        public string? Telefone { get; set; }

        public string? Celular { get; set; }

        public string? CelularSecundario { get; set; }

        //navegacao
        public virtual PerfilResponse? Perfil { get; set; }

        public virtual VagaResponse? Vaga { get; set; }

        public virtual HistoricoProfissionalResponse? HistoricoProfissional { get; set; }
    }
}
