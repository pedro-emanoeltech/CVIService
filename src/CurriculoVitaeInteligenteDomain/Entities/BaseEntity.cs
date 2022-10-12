using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public abstract class BaseEntity : ClassBase
    {
        [Key]
        public Guid? Id { get; set; }
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
