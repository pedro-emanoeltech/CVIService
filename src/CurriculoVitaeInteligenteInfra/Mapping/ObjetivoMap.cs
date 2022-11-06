using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class ObjetivoMap : BaseEntityComDataMap<Objetivo>
    {
        public override void Configure(EntityTypeBuilder<Objetivo> builder)
        {
            // chave
            base.Configure(builder);
            builder.Property(i => i.AreaInteresse).IsRequired(true).HasColumnType("varchar(200)").HasConversion(v => v == null ? null : v.ToLower(), v => v);
            builder.Property(i => i.PretensaoSalarial).HasColumnType("varchar(10)");
            builder.Property(i => i.ResumoProfissional).HasColumnType("varchar(500)");



        }
    }
}
