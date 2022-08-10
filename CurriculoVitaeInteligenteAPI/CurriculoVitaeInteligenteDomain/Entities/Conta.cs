using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CurriculoVitaeInteligenteDomain.Content.Enums.Classificacoes;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    internal class Conta : BaseEntityComData
    {

        public string? Email { get; set; }

        public string? Senha { get; set; }
        
        public TipoPerfil? TipoPerfil { get; set; }

        public Boolean Status { get; set; }

    }
}
