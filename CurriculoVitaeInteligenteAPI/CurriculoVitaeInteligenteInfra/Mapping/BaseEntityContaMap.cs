using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class BaseEntityContaMap<TEntity> : BaseEntityComDataMap<TEntity> where TEntity : BaseEntityConta
    {
        public override void BaseConfigure(EntityTypeBuilder<TEntity> builder)
        {
            // chave
            base.BaseConfigure(builder);
            builder.Property(i => i.ContaId).IsRequired();

        }
    }
}
