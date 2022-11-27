using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.Constants.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

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
            builder.Property(i => i.Role).HasMaxLength(20).HasConversion(new EnumToStringConverter<TipoConta>());

        }
    }
}
