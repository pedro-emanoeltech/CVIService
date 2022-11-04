using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
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
            builder.HasOne(i => i.Perfil).WithOne(p => p.HistoricoProfissional).HasForeignKey<HistoricoProfissional>(i => i.Perfil_Id).OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(i => i.Contato).WithOne(p => p.HistoricoProfissional).HasForeignKey<HistoricoProfissional>(i => i.Contato_Id).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(i => i.Cidade).WithOne(p => p.HistoricoProfissional).HasForeignKey<HistoricoProfissional>(i => i.Cidade_Id).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(i => i.Segmento).WithOne(p => p.HistoricoProfissional).HasForeignKey<HistoricoProfissional>(i => i.Segmento_Id).OnDelete(DeleteBehavior.Cascade);





        }
    }
}
