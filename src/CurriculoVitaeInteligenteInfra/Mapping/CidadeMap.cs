using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class CidadeMap : BaseMap<Cidade>
    {
        public override void Configure(EntityTypeBuilder<Cidade> builder)
        {
            // chave
            base.Configure(builder);
            builder.Property(i => i.Nome).IsRequired(true).HasMaxLength(50).HasConversion(v => v == null ? null : v.ToLower(), v => v);
            builder.Property(i => i.CodigoIBge).HasMaxLength(10);
        }
    }
}
