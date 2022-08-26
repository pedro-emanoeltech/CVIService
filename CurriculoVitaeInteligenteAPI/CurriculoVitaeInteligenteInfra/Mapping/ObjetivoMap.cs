using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class ObjetivoMap : BaseEntityComDataMap<Objetivo>
    {
        public override void BaseConfigure(EntityTypeBuilder<Objetivo> builder)
        {
            // chave
            base.BaseConfigure(builder);
            builder.Property(i => i.AreaInteresse).IsRequired(true).HasMaxLength(255).HasConversion(v => v == null ? null : v.ToLower(), v => v);
            builder.Property(i => i.PretensaoSalarial).HasMaxLength(20);
            builder.Property(i => i.ResumoProfissional).HasMaxLength(500);


            //indice
            builder.HasOne(i => i.Perfil).WithOne(p => p.Objetivo).HasForeignKey<Objetivo>(i => i.PerfilId).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(i => i.Cidade).WithOne(p => p.Objetivo).HasForeignKey<Objetivo>(i => i.CidadeRegiaoInteresseId).OnDelete(DeleteBehavior.Cascade);



        }
    }
}
