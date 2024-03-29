﻿using CurriculoVitaeInteligenteDomain.Content.Enums;


namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public class ContaDToResponse : BaseResponse
    {
        public Guid? Id { get; set; }
        public string? Email { get; set; }

        public TipoPerfil? TipoPerfil { get; set; }

        public Status Status { get; set; }
    }
}
