using CurriculoVitaeInteligenteDomain.Content.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CurriculoVitaeInteligenteDomain.Entities
{
   public  class PessoaFisica :BaseEntityConta
    {
        
        public string? Apelido { get; set; }

        public string? NomeCompleto { get; set; }

        public string? CPF { get; set; }

        public Guid? IdNacionalidade { get; set; }

        public EstadoCivil EstadoCivil { get; set; }

        public Genero Genero { get; set; }

        public Guid? IdEndereco { get; set; }

        public Guid? IdContato{ get; set; }

        public Guid? IdObjetivo { get; set; }


        //relacionamento
        public Nacionalidade? Nacionalidade { get; set; }

        public Endereco? Endereco { get; set; }

        public Contato? Contato { get; set; }

        public Objetivo? Objetivo{ get; set; }


        public virtual IList<Linguagem>? Linguagem { get; set; }
    }
}
