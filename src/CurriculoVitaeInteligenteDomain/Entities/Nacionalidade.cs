﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Nacionalidade: BaseEntity
    {
        public string? NomePais { get; set; }

        public virtual Perfil? Perfil { get; set; }

    }
}
