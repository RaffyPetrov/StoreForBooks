﻿using BookStore.Models.Requests;
using FluentValidation;

namespace BookStore.Validators
{
    public class AddAuthorRequestValidator :
        AbstractValidator<AddAuthorRequest>
    {
        public AddAuthorRequestValidator()
        {
            RuleFor(x => x.Bio)
                .NotNull()
                .NotEmpty().WithMessage("Bio can not be empty!");
            RuleFor(x => x.Bio.Length)
                .GreaterThan(5)
                .WithMessage("Minimum 5 characters")
                .LessThan(10).WithMessage("Maximum 10 characters");
        }
    }
}
