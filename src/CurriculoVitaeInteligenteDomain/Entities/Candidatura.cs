using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Candidatura :BaseEntityComData
    {
        public Guid? PerfilId { get; set; }
        public Guid? VagaId { get; set; }

        //navegaçao
        public virtual Perfil? Perfil { get; set; }
        public virtual Vaga? Vaga { get; set; }
    }
}
