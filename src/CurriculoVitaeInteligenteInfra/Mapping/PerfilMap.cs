using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class PerfilMap : BaseEntityContaMap<Perfil>
    {
        public override void Configure(EntityTypeBuilder<Perfil> builder)
        {
            // chave
            base.Configure(builder);
            builder.Property(i => i.Nome).HasMaxLength(30);
            builder.Property(i => i.Apelido).HasMaxLength(30);
            builder.Property(i => i.CNPJ).HasMaxLength(14);
            builder.Property(i => i.CPF).HasMaxLength(12);
            builder.Property(i => i.Idade).HasMaxLength(30);
            builder.Property(i => i.EstadoCivil).HasMaxLength(20).HasConversion(new EnumToStringConverter<EstadoCivil>());
            builder.Property(i => i.Genero).HasMaxLength(20).HasConversion(new EnumToStringConverter<Genero>());

            //relacionamento
            builder.HasOne(i => i.Segmento).WithOne(p => p.Perfil).HasForeignKey<Perfil>(i => i.SegmentoId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(i => i.Nacionalidade).WithOne(p => p.Perfil).HasForeignKey<Perfil>(i => i.NacionalidadeId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
