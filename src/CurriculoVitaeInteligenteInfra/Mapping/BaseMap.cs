using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public abstract class BaseMap<TEntityKey> : IEntityTypeConfiguration<TEntityKey> where TEntityKey : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntityKey> builder)
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
