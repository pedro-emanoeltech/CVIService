using CurriculoVitaeInteligenteApp.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteApp.DTOs.Request
{
    public class CargoRequest : BaseRequest
    {
        public Guid? HistoricoProfissional_Id{ get; set; }
        public string? NomeCargo { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Termino { get; set; }
        public string? DescricaoCargo { get; set; }

    }
}
