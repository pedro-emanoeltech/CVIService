using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class PaisMap : BaseMap<Pais>
    {
        public override void Configure(EntityTypeBuilder<Pais> builder)
        {
            // chave
            base.Configure(builder);
            builder.Property(i => i.Nome).IsRequired(true).HasMaxLength(55).HasConversion(v => v == null ? null : v.ToLower(), v => v);
            builder.Property(i => i.Sigla).HasMaxLength(3);




        }
    }
}
