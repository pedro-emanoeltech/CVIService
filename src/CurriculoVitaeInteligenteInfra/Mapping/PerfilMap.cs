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
            builder.Property(i => i.Nome).HasColumnType("varchar(150)");
            builder.Property(i => i.Apelido).HasColumnType("varchar(50)");
            builder.Property(i => i.CNPJ).HasColumnType("varchar(14)");
            builder.Property(i => i.CPF).HasColumnType("varchar(12)");
            builder.Property(i => i.Idade).HasColumnType("varchar(3)");
            builder.Property(i => i.EstadoCivil).HasColumnType("varchar(30)").HasConversion(new EnumToStringConverter<EstadoCivil>());
            builder.Property(i => i.Genero).HasColumnType("varchar(20)").HasConversion(new EnumToStringConverter<Genero>());
            builder.Property(i => i.TipoPerfil).HasMaxLength(5).HasConversion(new EnumToStringConverter<TipoPerfil>());

            //relacionamento
            builder.HasOne(i => i.Conta).WithMany().HasForeignKey(i=>i.ContaId).OnDelete(DeleteBehavior.Cascade);

            
            builder.HasOne(i => i.Escolaridade).WithOne().HasForeignKey<Escolaridade>(i => i.PerfilId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(i => i.Endereco).WithOne().HasForeignKey<Endereco>(i => i.PerfilId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(i => i.Objetivo).WithOne().HasForeignKey<Objetivo>(i => i.PerfilId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(i => i.Idioma).WithOne().HasForeignKey<Idioma>(i => i.PerfilId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(i => i.HistoricoProfissional).WithOne().HasForeignKey(i => i.PerfilId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(i => i.CursoFormacaoAcademica).WithOne().HasForeignKey(i => i.PerfilId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(i => i.Contato).WithOne().HasForeignKey(i => i.PerfilId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
