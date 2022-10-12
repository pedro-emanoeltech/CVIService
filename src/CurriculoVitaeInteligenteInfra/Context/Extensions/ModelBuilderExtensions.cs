using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteInfra.Context.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder AdicionarOrAtualizarDatas(this ModelBuilder builder)
        {

            return builder;

        }
    }
}
