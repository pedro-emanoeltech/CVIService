using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteInfra.Mapping
{
    public abstract class BaseEntityComDataMap<TEntity> : BaseMap<TEntity> where TEntity : BaseEntityComData
    {
        public override void BaseConfigure(EntityTypeBuilder<TEntity> builder)
        {
            // chave
            base.BaseConfigure(builder);
            builder.Property(x => x.DateCreate).IsRequired();
            builder.Property(x => x.DateUpdate).IsRequired(false);

            // index
            builder.HasIndex(x => x.DateCreate).IsUnique(false);


        }
    }   
}
