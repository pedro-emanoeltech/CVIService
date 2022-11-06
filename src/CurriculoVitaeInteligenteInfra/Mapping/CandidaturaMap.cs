using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class CandidaturaMap : BaseEntityComDataMap<Candidatura>
    {
        public override void Configure(EntityTypeBuilder<Candidatura> builder)
        {
            // chave
            base.Configure(builder);

            //indice
            builder.HasOne(i => i.Perfil).WithMany().HasForeignKey(i => i.PerfilId);
            builder.HasOne(i => i.Vaga).WithMany().HasForeignKey(i => i.VagaId);



        }
    }
}
