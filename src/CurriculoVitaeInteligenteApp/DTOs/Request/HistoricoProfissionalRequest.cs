using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteDomain.Content.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CurriculoVitaeInteligenteDomain.Content.Enums.Classificacoes;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class HistoricoProfissionalRequest : BaseRequest
    {
        public Guid? Perfil_Id { get; set; }

        public string? NomeEmpresa { get; set; }
        public PorteEmpresa? Porte { get; set; }

        public Guid? Contato_Id { get; set; }
        public Guid? Cidade_Id { get; set; }
        public Guid? Segmento_Id { get; set; }



   
    }
}
