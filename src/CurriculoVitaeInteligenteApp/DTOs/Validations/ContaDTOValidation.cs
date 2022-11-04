using CurriculoVitaeInteligenteApp.DTOs.Request;
using FluentValidation;


namespace CurriculoVitaeInteligenteApp.DTOs.Validations
{
    public class ContaDTOValidation: BaseDTOValidations<ContaRequest>
    {
        public ContaDTOValidation()
        {
            RuleFor(x=>x.Email)
                .NotEmpty()
                .NotNull()
                .WithMessage("Email deve ser preenchido");
        }


    }
  
}
