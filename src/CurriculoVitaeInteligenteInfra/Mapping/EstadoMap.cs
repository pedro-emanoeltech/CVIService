using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class EstadoMap : BaseMap<Estado>
    {
        public override void Configure(EntityTypeBuilder<Estado> builder)
        {
            // chave
            base.Configure(builder);
            builder.Property(i => i.Nome).IsRequired(true).HasMaxLength(55).HasConversion(v => v == null ? null : v.ToLower(), v => v);
            builder.Property(i => i.UF).IsRequired(true).HasMaxLength(3);

            //indice
            builder.HasIndex(p => p.UF).IsUnique(true);


           

        }
    }
}
