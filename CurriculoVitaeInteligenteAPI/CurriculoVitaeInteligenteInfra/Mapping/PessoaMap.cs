using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class PessoaMap : BaseEntityComDataMap<Pessoa>
    {
        public override void BaseConfigure(EntityTypeBuilder<Pessoa> builder)
        {
            // chave
            base.BaseConfigure(builder);
            builder.Property(i => i.Apelido).HasMaxLength(30);


        }
    }
}
