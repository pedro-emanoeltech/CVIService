using CurriculoVitaeInteligenteApp.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public class EstadoResponse : BaseResponse
    {
        public Guid? Pais_Id { get; set; }
        public string? Nome { get; set; }
        public string? UF { get; set; }


        public virtual EnderecoResponse? Endereco { get; set; }

        //navegaçao

        public  PaisResponse? Pais { get; set; }
    }
}
