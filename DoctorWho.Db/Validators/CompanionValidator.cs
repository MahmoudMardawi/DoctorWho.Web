using DoctorWho.Db.Domain.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Validators
{
    public class CompanionValidator : AbstractValidator<CompanionDto>
    {
        public CompanionValidator()
        {
            RuleFor(c => c.CompanionId).NotNull().NotEmpty();
            RuleFor(c => c.CompanionName).NotEmpty().MaximumLength(50);
        }
    }
}
