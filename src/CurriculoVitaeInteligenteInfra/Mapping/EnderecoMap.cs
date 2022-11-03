using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class EnderecoMap : BaseEntityComDataMap<Endereco>
    {
        public override void Configure(EntityTypeBuilder<Endereco> builder)
        {
            // chave
            base.Configure(builder);
            builder.Property(i => i.EnderecoPerfil).HasMaxLength(30);
            builder.Property(i => i.Bairro).HasMaxLength(30);
            builder.Property(i => i.Numero).HasMaxLength(7);
            builder.Property(i => i.CEP).HasMaxLength(8);
            builder.Property(i => i.Complemento).HasMaxLength(50);




            //navegação
            builder.HasOne(i => i.Perfil).WithOne(p => p.Endereco).HasForeignKey<Endereco>(i => i.Perfil_Id).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(i => i.Vaga).WithOne(p => p.Endereco).HasForeignKey<Endereco>(i => i.Vaga_Id).OnDelete(DeleteBehavior.Cascade);

            //relacionamento
            builder.HasOne(i => i.Cidade).WithOne(p => p.Endereco).HasForeignKey<Endereco>(i => i.Cidade_Id).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(i => i.Estado).WithOne(p => p.Endereco).HasForeignKey<Endereco>(i => i.Estado_Id).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
