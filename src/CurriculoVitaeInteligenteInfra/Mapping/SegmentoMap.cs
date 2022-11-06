using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class SegmentoMap : BaseMap<Segmento>
    {
        public override void Configure(EntityTypeBuilder<Segmento> builder)
        {
            // chave
            base.Configure(builder);
            builder.Property(i => i.Setor).HasMaxLength(30);
    
            

        }
    }
}
