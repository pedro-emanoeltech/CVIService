using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public class EnderecoResponse : BaseResponse
    {
        public Guid? PerfilId { get; set; }
        public Guid? VagaId { get; set; }
        public Guid? CidadeId { get; set; }
        public Guid? EstadoId { get; set; }

        public string? Logradouro { get; set; }

        public string? Bairro { get; set; }

        public Int64? Numero { get; set; }

        public Int64? CEP { get; set; }

        public string? Complemento { get; set; }



        //relacionamento
        public Cidade? Cidade { get; set; }
        public Estado? Estado { get; set; }

    }
}
