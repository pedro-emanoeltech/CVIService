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
            builder.Property(i => i.TipoPerfil).HasMaxLength(10).HasConversion(new EnumToStringConverter<TipoPerfil>());
            builder.Property(i => i.ModalidadeTrabalho).HasMaxLength(20).HasConversion(new EnumToStringConverter<ModalidadeTrabalho>());

            builder.HasOne(i => i.Endereco).WithOne(p => p.Vaga).HasForeignKey<Vaga>(i => i.Endereco_Id).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(i => i.Contato).WithOne(p => p.Vaga).HasForeignKey<Vaga>(i => i.Contato_Id).OnDelete(DeleteBehavior.Cascade);
            

        }
    }
}
