using DoctorWho.Db.Domain.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Validators
{
    public class DoctorValidator : AbstractValidator<DoctorDto>
    {
        public DoctorValidator()
        {
            RuleFor(d => d.DoctorId).NotNull().NotEmpty();
            RuleFor(d => d.DoctorName).NotEmpty().MaximumLength(50);
            RuleFor(d => d.BirthDate).NotEmpty();
            RuleFor(d => d.DoctorNumber).NotEmpty();
            RuleFor(d => d.LastEpisodeDate).GreaterThan(d => d.FirstEpisodeDate)
                .WithMessage("The last episode date should be later than first episode date");
        }
    }
}
