using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class ContaMap : BaseEntityComDataMap<Conta>
    {
        public override void Configure(EntityTypeBuilder<Conta> builder)
        {
            // chave
            base.Configure(builder);
            builder.Property(i => i.Email).IsRequired(true).HasMaxLength(255).HasConversion(v => v == null ? null : v.ToLower(), v => v);
            builder.Property(i => i.Senha).IsRequired(true).HasMaxLength(255);
            builder.Property(i => i.TipoPerfil).HasMaxLength(5).HasConversion(new EnumToStringConverter<TipoPerfil>());
            builder.Property(i => i.Status).HasMaxLength(10).HasConversion(new EnumToStringConverter<Status>());

            //indice
            builder.HasIndex(i => i.Email).IsUnique(true);



        }
    }
}
