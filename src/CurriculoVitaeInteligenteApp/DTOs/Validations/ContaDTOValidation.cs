using FluentValidation;


namespace CurriculoVitaeInteligenteApp.DTOs.Validations
{
    public class ContaDTOValidation: BaseDTOValidations<ContaDTo>
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
