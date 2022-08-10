﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Endereco :BaseEntityComData
    {
        public string? EnderecoPessoa { get; set; }

        public string? Bairro { get; set; }

        public string? Numero { get; set; }

        public string? CEP { get; set; }

        public string?  Complemento { get; set; }

        public Guid? IdCidade { get; set; }
       


        //relacionamento
        public Cidade? Cidade { get; set; }

    }
}
