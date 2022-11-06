using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class IdiomaMap : BaseMap<Idioma>
    {
        public override void Configure(EntityTypeBuilder<Idioma> builder)
        {
            // chave
            base.Configure(builder);
            builder.Property(i => i.Nome).IsRequired(true).HasColumnType("varchar(255)").HasConversion(v => v == null ? null : v.ToLower(), v => v);
            builder.Property(i => i.NivelLeitura).HasMaxLength(20).HasConversion(new EnumToStringConverter<NivelLinguagem>());
            builder.Property(i => i.NivelEscrita).HasMaxLength(20).HasConversion(new EnumToStringConverter<NivelLinguagem>());
            builder.Property(i => i.NivelConversacao).HasMaxLength(20).HasConversion(new EnumToStringConverter<NivelLinguagem>());

        }
    }
}
