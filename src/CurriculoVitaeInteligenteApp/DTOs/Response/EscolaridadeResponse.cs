﻿using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteDomain.Content.Enums;

namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public class EscolaridadeResponse : BaseResponse
    {
        public Guid? PerfilId { get; set; }
        public NivelAcademico? NivelAcademico { get; set; }

    }
}
