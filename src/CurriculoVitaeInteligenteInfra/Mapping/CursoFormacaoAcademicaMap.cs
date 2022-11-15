using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.Constants.Enums;
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
            builder.Property(i => i.Instituicao).IsRequired(true).HasColumnType("varchar(150)").HasConversion(v => v == null ? null : v.ToLower(), v => v);
            builder.Property(i => i.DescricaoCurso).HasColumnType("varchar(500)"); ;
            builder.Property(i => i.SituacaoCurso).HasColumnType("varchar(500)").HasConversion(new EnumToStringConverter<SituacaoCurso>());


            //relacionamento
            builder.HasOne(i => i.Cidade).WithMany().HasForeignKey(i => i.CidadeId);
            builder.HasOne(i => i.Curso).WithMany().HasForeignKey(i => i.CursoId);
        }
    }
}
