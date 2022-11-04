using CurriculoVitaeInteligenteApp.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public class CursoResponse : BaseResponse
    {

        public string? NomeCurso { get; set; }

        public virtual CursoFormacaoAcademicaResponse? CursoFormacaoAcademica { get; set; }



}
}
