using CurriculoVitaeInteligenteDomain.Content.Enums;
using System;


namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Conta : BaseEntityComData
    {

        public string? Email { get; set; }

        public string? Senha { get; set; }
        
        public TipoPerfil? TipoPerfil { get; set; }

        public Status Status { get; set; } = Status.Ativo;

        public virtual Pessoa? Pessoa { get; set; }

    }
}
