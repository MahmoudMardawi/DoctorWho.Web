using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Profiles
{
    internal class CompanionProfile : Profile
    {
        public CompanionProfile()
        {
            CreateMap<DoctorWho.Db.Domain.Models.Companion,
                DoctorWho.Db.Domain.Dtos.CompanionDto>(MemberList.Source)
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
        }
    }
}
