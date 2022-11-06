﻿using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public class EstadoResponse : BaseResponse
    {
        public Guid? PaisId { get; set; }
        public string? Nome { get; set; }
        public string? UF { get; set; }

        //navegacao
        public Pais? Pais { get; set; }
    }
}
