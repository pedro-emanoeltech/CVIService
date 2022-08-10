using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public abstract class BaseEntityConta :BaseEntityComData
    {
        public Guid? IdConta { get; private set; }
    }
}
