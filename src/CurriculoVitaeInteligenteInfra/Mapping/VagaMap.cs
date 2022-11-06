using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class VagaMap : BaseEntityComDataMap<Vaga>
    {
        public override void Configure(EntityTypeBuilder<Vaga> builder)
        {
            // chave
            base.Configure(builder);
            builder.Property(i => i.Titulo).HasMaxLength(100);
            builder.Property(i => i.Descricao).HasMaxLength(500);
            builder.Property(i => i.NomeEmpresa).HasMaxLength(100);
            builder.Property(i => i.Requisitos).HasMaxLength(500);
            builder.Property(i => i.Beneficio).HasMaxLength(300);
            builder.Property(i => i.ModalidadeTrabalho).HasMaxLength(20).HasConversion(new EnumToStringConverter<ModalidadeTrabalho>());

            builder.HasOne(i => i.Perfil).WithOne().HasForeignKey<Vaga>(i => i.PerfilId);

            builder.HasOne(i => i.Contato).WithOne().HasForeignKey<Contato>(i => i.VagaId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(i => i.Endereco).WithOne().HasForeignKey<Endereco>(i => i.VagaId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
