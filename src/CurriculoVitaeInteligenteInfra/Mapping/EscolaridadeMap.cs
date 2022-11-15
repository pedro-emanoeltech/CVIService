﻿using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.Constants.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class EscolaridadeMap : BaseMap<Escolaridade>
    {
        public override void Configure(EntityTypeBuilder<Escolaridade> builder)
        {
            // chave
            base.Configure(builder);
            builder.Property(i => i.NivelAcademico).HasMaxLength(20).HasConversion(new EnumToStringConverter<NivelAcademico>());

        }
    }
}
