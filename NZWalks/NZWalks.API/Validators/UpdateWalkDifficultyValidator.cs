using FluentValidation;
using NZWalks.API.Models.DTO;

namespace NZWalks.API.Validators
{
    public class UpdateWalkDifficultyValidator : AbstractValidator<UpdateWalkDifficulty>
    {
        public UpdateWalkDifficultyValidator()
        {
            RuleFor(x => x.Code).NotEmpty();
        }
    }
}
