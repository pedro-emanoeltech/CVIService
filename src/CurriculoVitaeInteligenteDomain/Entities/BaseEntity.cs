using CurriculoVitaeInteligenteDomain.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public abstract class BaseEntity : ClassBase, IAddContextBaseProperty
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid? Id { get; set; }
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
