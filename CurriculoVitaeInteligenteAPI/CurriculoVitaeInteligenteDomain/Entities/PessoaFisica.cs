using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CurriculoVitaeInteligenteDomain.Content.Enums.Classificacoes;

namespace CurriculoVitaeInteligenteDomain.Entities
{
   public  class PessoaFisica :BaseEntityConta
    {
        public string? Apelido { get; set; }

        public string? NomeCompleto { get; set; }

        public string? CPF { get; set; }

        public string? Nacionalidade { get; set; }

        public EstadoCivil EstadoCivil { get; set; }

        public Genero Genero { get; set; }

    }
}
