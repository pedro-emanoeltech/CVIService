using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class EnderecoMap : BaseEntityComDataMap<Endereco>
    {
        public override void BaseConfigure(EntityTypeBuilder<Endereco> builder)
        {
            // chave
            base.BaseConfigure(builder);
            builder.Property(i => i.EnderecoPerfil).HasMaxLength(30);
            builder.Property(i => i.Bairro).HasMaxLength(30);
            builder.Property(i => i.Numero).HasMaxLength(7);
            builder.Property(i => i.CEP).HasMaxLength(8);
            builder.Property(i => i.Complemento).HasMaxLength(50);




            //navegação
            builder.HasOne(i => i.Perfil).WithOne(p => p.Endereco).HasForeignKey<Endereco>(i => i.PerfilId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(i => i.Vaga).WithOne(p => p.Endereco).HasForeignKey<Endereco>(i => i.VagaId).OnDelete(DeleteBehavior.Cascade);

            //relacionamento
            builder.HasOne(i => i.Cidade).WithOne(p => p.Endereco).HasForeignKey<Endereco>(i => i.IdCidade).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(i => i.Estado).WithOne(p => p.Endereco).HasForeignKey<Endereco>(i => i.IdEstado).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
