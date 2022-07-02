using DoctorWho.Db.Domain.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Validators
{
    public class AuthorValidator : AbstractValidator<AuthorDto>
    {
        public AuthorValidator()
        {
            RuleFor(a => a.AuthorId).NotNull().NotEmpty();
            RuleFor(a => a.AuthorName).NotEmpty().MaximumLength(50);
        }
    }
}
