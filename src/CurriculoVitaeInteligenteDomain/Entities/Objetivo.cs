using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Objetivo :BaseEntityComData
    {

        public Guid? Perfil_Id { get; set; }
        public string? AreaInteresse { get; set; }

        public double? PretensaoSalarial { get; set; }

        public string? ResumoProfissional { get; set; }

        public Guid? CidadeRegiaoInteresse_Id { get; set; }

        //relacionamento
        public Cidade? Cidade { get; set; }

        //navegaçao
        public virtual Perfil? Perfil { get; set; }
    }
}
