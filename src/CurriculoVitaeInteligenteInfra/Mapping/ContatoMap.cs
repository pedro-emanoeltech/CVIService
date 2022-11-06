﻿using CurriculoVitaeInteligenteDomain.Content.Enums;
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
            builder.Property(i => i.TipoContato).HasColumnType("varchar(15)").HasConversion(new EnumToStringConverter<TipoContato>());
            builder.Property(i => i.Texto).HasMaxLength(20);

        }
    }
}
