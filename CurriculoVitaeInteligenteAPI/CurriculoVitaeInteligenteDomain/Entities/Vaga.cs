using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CurriculoVitaeInteligenteDomain.Content.Enums.Classificacoes;

namespace CurriculoVitaeInteligenteDomain.Entities
{
   public  class Vaga  :BaseEntityConta
    {

        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public string? NomeEmpresa { get; set; }
        public string? Requisitos { get; set; }

        public string? Beneficio { get; set; }

        public TipoPerfil? Perfil { get; set; }
        public ModalidadeTrabalho? modalidadeTrabalho{ get; set; }



        public Guid? IdEndereco { get; set; }

        public Guid? IdContato{ get; set; }



        //relacionamento

        public Endereco? Endereco { get; set; }

        public Contato? Contato { get; set; }

    }
}
