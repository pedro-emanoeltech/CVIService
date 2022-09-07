using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class CursoFormacaoAcademicaMap : BaseEntityComDataMap<CursoFormacaoAcademica>
    {
        public override void Configure(EntityTypeBuilder<CursoFormacaoAcademica> builder)
        {
            // chave
            base.Configure(builder);
            builder.Property(i => i.Instituicao).IsRequired(true).HasMaxLength(255).HasConversion(v => v == null ? null : v.ToLower(), v => v);
            builder.Property(i => i.DescricaoCurso).HasMaxLength(300);
            builder.Property(i => i.SituacaoCurso).HasMaxLength(20).HasConversion(new EnumToStringConverter<SituacaoCurso>());

            //indice
            builder.HasOne(i => i.Perfil).WithOne(p => p.CursoFormacaoAcademica).HasForeignKey<CursoFormacaoAcademica>(i => i.PerfilId).OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(i => i.Curso).WithOne(p => p.CursoFormacaoAcademica).HasForeignKey<CursoFormacaoAcademica>(i => i.CursoId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(i => i.Cidade).WithOne(p => p.CursoFormacaoAcademica).HasForeignKey<CursoFormacaoAcademica>(i => i.CidadeId).OnDelete(DeleteBehavior.Cascade);




        }
    }
}
