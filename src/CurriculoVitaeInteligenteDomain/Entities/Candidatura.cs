using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Candidatura :BaseEntityComData
    {

        public Guid? VagaId { get; set; }
        public Guid? PerfilId { get; set; }
        

        
        public virtual Vaga? Vaga { get; set; }
        public virtual Perfil? Perfil { get; set; }

    }
}
