using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class SegmentoMap : BaseMap<Segmento>
    {
        public override void BaseConfigure(EntityTypeBuilder<Segmento> builder)
        {
            // chave
            base.BaseConfigure(builder);
            builder.Property(i => i.Descricao).HasMaxLength(30);
    
            

        }
    }
}
