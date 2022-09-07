using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class NacionalidadeMap : BaseMap<Nacionalidade>
    {
        public override void Configure(EntityTypeBuilder<Nacionalidade> builder)
        {
            // chave
            base.Configure(builder);
            builder.Property(i => i.Nome).IsRequired(true).HasMaxLength(255);

        }
    }
}
