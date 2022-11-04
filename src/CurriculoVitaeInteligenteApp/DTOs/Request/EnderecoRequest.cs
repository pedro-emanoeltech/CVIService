using CurriculoVitaeInteligenteApp.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class EnderecoRequest : BaseRequest
    {
        public Guid? Perfil_Id { get; set; }
        public Guid? Vaga_Id { get; set; }

        public string? EnderecoPerfil { get; set; }

        public string? Bairro { get; set; }

        public Int64? Numero { get; set; }

        public Int64? CEP { get; set; }

        public string?  Complemento { get; set; }

        public Guid? Cidade_Id { get; set; }

        public Guid? Estado_Id{ get; set; }

    }
}
