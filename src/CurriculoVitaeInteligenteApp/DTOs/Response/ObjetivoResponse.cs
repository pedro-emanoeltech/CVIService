using CurriculoVitaeInteligenteApp.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public class ObjetivoResponse : BaseResponse
    {

        public Guid? PerfilId { get; set; }
        public string? AreaInteresse { get; set; }

        public double? PretensaoSalarial { get; set; }

        public string? ResumoProfissional { get; set; }

        public Guid? CidadeRegiaoInteresse_Id { get; set; }

        //relacionamento
        public CidadeResponse? Cidade { get; set; }

        //navegaçao
        public virtual PerfilResponse? Perfil { get; set; }
    }
}
