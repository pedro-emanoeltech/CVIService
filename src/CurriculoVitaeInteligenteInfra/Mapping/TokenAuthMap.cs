using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class TokenAuthMap : BaseEntityComDataMap<TokenAuth>
    { 
        public override void Configure(EntityTypeBuilder<TokenAuth> builder)
        {
            // chave
            base.Configure(builder);
            builder.Property(i => i.Token).IsRequired(true).HasMaxLength(600).HasConversion(v => v == null ? null : v.ToLower(), v => v);
            builder.Property(i => i.ContaId).HasMaxLength(300);

        }
    }
}
