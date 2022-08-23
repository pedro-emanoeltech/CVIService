using System.Data.Entity.Core;
using System.Data.Entity.ModelConfiguration;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public abstract class BaseMap<TEntityKey> : EntityTypeConfiguration<TEntityKey> where TEntityKey : BaseEntity
    {
        public virtual void BaseConfigure(EntityTypeBuilder<TEntityKey> builder)
        {
            // chave
            builder.HasKey(x => x.Id);

            // campos

            builder.Property(x => x.Id).IsRequired(true).ValueGeneratedNever();

            // index
            builder.HasIndex(x => x.Id).IsUnique();
        }

    }
}
