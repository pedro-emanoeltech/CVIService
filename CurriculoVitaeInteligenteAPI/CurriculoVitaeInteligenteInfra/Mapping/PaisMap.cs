using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class PaisMap : BaseMap<Pais>
    {
        public override void BaseConfigure(EntityTypeBuilder<Pais> builder)
        {
            // chave
            base.BaseConfigure(builder);
            builder.Property(i => i.Nome).IsRequired(true).HasMaxLength(55).HasConversion(v => v == null ? null : v.ToLower(), v => v);
            builder.Property(i => i.Sigla).HasMaxLength(3);




        }
    }
}
