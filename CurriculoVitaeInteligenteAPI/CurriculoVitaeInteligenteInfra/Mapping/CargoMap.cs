using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class CargoMap : BaseEntityComDataMap<Cargo>
    {
        public override void BaseConfigure(EntityTypeBuilder<Cargo> builder)
        {
            // chave
            base.BaseConfigure(builder);
            builder.Property(i => i.NomeCargo).IsRequired(true).HasMaxLength(255).HasConversion(v => v == null ? null : v.ToLower(), v => v);
            builder.Property(i => i.DescricaoCargo).HasMaxLength(300);

            //indice
            builder.HasOne(i => i.HistoricoProfissional).WithMany(p => p.Cargo).HasForeignKey(i => i.HistoricoProfissionalId).OnDelete(DeleteBehavior.Cascade);





        }
    }
}
