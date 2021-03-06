using System;
using FluentValidation;
using Data;


namespace ModelValidators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8);
        }

    }
}
