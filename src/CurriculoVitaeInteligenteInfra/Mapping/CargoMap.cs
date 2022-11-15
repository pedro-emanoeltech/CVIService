using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class CargoMap : BaseEntityComDataMap<Cargo>
    {
        public override void Configure(EntityTypeBuilder<Cargo> builder)
        {
            // chave
            base.Configure(builder);
            builder.Property(i => i.NomeCargo).IsRequired(true).HasMaxLength(255).HasConversion(v => v == null ? null : v.ToLower(), v => v);
            builder.Property(i => i.DescricaoCargo).HasMaxLength(300);

         
          





        }
    }
}
