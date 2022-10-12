using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public abstract class BaseEntityComData: BaseEntity
    {
        public DateTime? DateCreate { get; set; }

        public DateTime? DateUpdate { get; set; }
    }
}
