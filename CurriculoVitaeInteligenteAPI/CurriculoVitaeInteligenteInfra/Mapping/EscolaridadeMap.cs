﻿using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public class EscolaridadeMap : BaseMap<Escolaridade>
    {
        public override void BaseConfigure(EntityTypeBuilder<Escolaridade> builder)
        {
            // chave
            base.BaseConfigure(builder);
            builder.Property(i => i.NivelAcademico).HasMaxLength(20).HasConversion(new EnumToStringConverter<NivelAcademico>());



        }
    }
}
