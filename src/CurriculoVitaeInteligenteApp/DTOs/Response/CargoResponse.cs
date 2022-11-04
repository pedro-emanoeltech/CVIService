﻿using CurriculoVitaeInteligenteApp.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public class CargoResponse : BaseResponse
    {
        public Guid? HistoricoProfissional_Id{ get; set; }
        public string? NomeCargo { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Termino { get; set; }
        public string? DescricaoCargo { get; set; }

        //navegacao
        public virtual HistoricoProfissionalResponse? HistoricoProfissional { get; set; }
    }
}
