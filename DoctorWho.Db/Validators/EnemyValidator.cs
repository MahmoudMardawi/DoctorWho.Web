using DoctorWho.Db.Domain.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Validators
{
    public class EnemyValidator : AbstractValidator<EnemyDto>
    {
        public EnemyValidator()
        {
            RuleFor(e => e.EnemyId).NotNull().NotEmpty();
            RuleFor(e => e.EnemyName).NotEmpty().MaximumLength(50);
            RuleFor(e => e.Description).MaximumLength(250);
        }
    }
}
