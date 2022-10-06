using FluentValidation;
using NZWalks.API.Models.DTO;

namespace NZWalks.API.Validators
{
    public class AddWalkDifficultyValidator : AbstractValidator<AddWalkDifficulty>
    {
        public AddWalkDifficultyValidator()
        {
            RuleFor(x => x.Code).NotEmpty();
        }
    }
}
