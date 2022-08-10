using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Content.Enums
{
    public  class Classificacoes
    {
        public enum TipoPerfil 
        {
            CPF,
            CNPJ
        }
        public enum EstadoCivil
        {
            Solteiro,
            Casado,
            Separado,
            Divorciado,
            Viuvo
        }
        public enum Genero
        {
            Feminino,
            Masculino,
            NaoBinario,
            Outros,
            NaoInformar
        }
        public enum OrientacaoSexual
        {
            Assexual,
            Bissexual,
            Heterossexual,
            Homossexual,
            Pansexual,
            NaoInformar
        }
        public enum IdentidadeGenero
        {
            Cisgenero,
            Transgênero,
            NaoInformar
        }
        public enum CorPele
        {
            Amarela,
            Branca,
            Indígena,
            Parda,
            Preta,
            NaoInformar
        }

    }
}
