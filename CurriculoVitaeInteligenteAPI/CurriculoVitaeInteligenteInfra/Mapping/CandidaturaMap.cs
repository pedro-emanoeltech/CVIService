using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class CandidaturaMap : BaseEntityComDataMap<Candidatura>
    {
        public override void BaseConfigure(EntityTypeBuilder<Candidatura> builder)
        {
            // chave
            base.BaseConfigure(builder);

            //indice
            builder.HasOne(i => i.Perfil).WithMany(p => p.Candidatura).HasForeignKey(i => i.PerfilId).OnDelete(DeleteBehavior.Cascade);




        }
    }
}
