using CurriculoVitaeInteligenteApp.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteApp.DTOs.Request
{
    public class CidadeRequest : BaseRequest
    {

        public string? Nome { get; set; }

        public string? CodigoIBge { get; set; }

    }
}
