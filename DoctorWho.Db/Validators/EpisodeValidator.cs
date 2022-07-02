using DoctorWho.Db.Domain.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Validators
{
    public class EpisodeValidator : AbstractValidator<EpisodeDto>
    {
        public EpisodeValidator()
        {
            RuleFor(e => e.EpisodeNumber).NotEmpty();
            RuleFor(e => e.SeriesNumber).NotEmpty();
            RuleFor(e => e.EpisodeType).NotEmpty().MaximumLength(100);
            RuleFor(e => e.EpisodeDate).NotEmpty();
            RuleFor(e => e.Title).NotEmpty().MaximumLength(100);
            RuleFor(e => e.Notes).MaximumLength(250);
 
        }
    }
}
