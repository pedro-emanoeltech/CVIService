using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class EnderecoMap : BaseEntityComDataMap<Endereco>
    {
        public override void Configure(EntityTypeBuilder<Endereco> builder)
        {
            // chave
            base.Configure(builder);
            builder.Property(i => i.Logradouro).HasMaxLength(30);
            builder.Property(i => i.Bairro).HasMaxLength(30);
            builder.Property(i => i.Numero).HasMaxLength(7);
            builder.Property(i => i.CEP).HasMaxLength(8);
            builder.Property(i => i.Complemento).HasMaxLength(50);

            //relacionamento
            builder.HasOne(i => i.Cidade).WithOne().HasForeignKey<Endereco>(i => i.CidadeId);
            builder.HasOne(i => i.Estado).WithOne().HasForeignKey<Endereco>(i => i.EstadoId);

            
        }
    }
}
