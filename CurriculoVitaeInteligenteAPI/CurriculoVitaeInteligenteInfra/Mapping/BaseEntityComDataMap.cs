using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public abstract class BaseEntityComDataMap<TEntity> : BaseMap<TEntity> where TEntity : BaseEntityComData
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            // chave
            base.Configure(builder);
            builder.Property(x => x.DateCreate).IsRequired();
            builder.Property(x => x.DateUpdate).IsRequired(false);

            // index
            builder.HasIndex(x => x.DateCreate).IsUnique(false);


        }
    }   
}
