using CurriculoVitaeInteligenteDomain.Content.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CurriculoVitaeInteligenteDomain.Content.Enums.Classificacoes;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Linguagem :BaseEntityComData
    {

        public Guid? IdPerfil{ get; set; }

        public NivelLinguagem? NivelLeitura { get; set; }

        public NivelLinguagem? NivelEscrita { get; set; }

        public NivelLinguagem? NivelConversacao { get; set; }

        //relacionamento
        public Idioma? Idioma { get; set; }

        //navegaçao 
        public virtual PessoaFisica? PessoaFisica { get; set; }
    }
}
