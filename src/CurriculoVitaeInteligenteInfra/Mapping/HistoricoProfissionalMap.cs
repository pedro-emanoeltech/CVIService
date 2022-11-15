using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.Constants.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class HistoricoProfissionalMap : BaseEntityComDataMap<HistoricoProfissional>
    {
        public override void Configure(EntityTypeBuilder<HistoricoProfissional> builder)
        {
            // chave
            base.Configure(builder);
            builder.Property(i => i.NomeEmpresa).IsRequired(true).HasMaxLength(255).HasConversion(v => v == null ? null : v.ToLower(), v => v);
            builder.Property(i => i.Porte).HasMaxLength(30).HasConversion(new EnumToStringConverter<PorteEmpresa>());

            //indice
            builder.HasOne(i => i.Segmento).WithOne().HasForeignKey<HistoricoProfissional>(i => i.SegmentoId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(i => i.Cargo).WithOne().HasForeignKey<Cargo>(i => i.HistoricoProfissionalId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(i => i.Contato).WithOne().HasForeignKey<HistoricoProfissional>(i => i.ContatoId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(i => i.Cidade).WithOne().HasForeignKey<HistoricoProfissional>(i => i.CidadeId).OnDelete(DeleteBehavior.Cascade);
          





        }
    }
}
