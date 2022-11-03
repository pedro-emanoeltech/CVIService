using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class ContatoMap : BaseEntityComDataMap<Contato>
    {
        public override void Configure(EntityTypeBuilder<Contato> builder)
        {
            // chave
            base.Configure(builder);
            builder.Property(i => i.Email).IsRequired(true).HasMaxLength(255).HasConversion(v => v == null ? null : v.ToLower(), v => v);
            builder.Property(i => i.Telefone).HasMaxLength(20);
            builder.Property(i => i.Celular).HasMaxLength(20);
            builder.Property(i => i.CelularSecundario).HasMaxLength(20);

            //indice
            builder.HasOne(i => i.Perfil).WithOne(p => p.Contato).HasForeignKey<Contato>(i => i.Perfil_Id).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(i => i.Vaga).WithOne(p => p.Contato).HasForeignKey<Contato>(i => i.VagaId).OnDelete(DeleteBehavior.Cascade);



        }
    }
}
