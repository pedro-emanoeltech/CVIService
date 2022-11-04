using CurriculoVitaeInteligenteApp.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public class CidadeResponse : BaseResponse
    {

        public string? Nome { get; set; }

        public string? CodigoIBge { get; set; }

        public virtual EnderecoResponse? Endereco { get; set; }

        public virtual ObjetivoResponse? Objetivo { get; set; }

        public virtual HistoricoProfissionalResponse? HistoricoProfissional { get; set; }
        public virtual CursoFormacaoAcademicaResponse? CursoFormacaoAcademica { get; set; }
        

    }
}
