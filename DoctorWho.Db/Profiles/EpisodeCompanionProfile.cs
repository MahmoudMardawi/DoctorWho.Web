using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Profiles
{
    internal class EpisodeCompanionProfile : Profile
    {
        public EpisodeCompanionProfile()
        {
            this.CreateMap<DoctorWho.Db.Domain.Models.EpisodeCompanion, 
                DoctorWho.Db.Domain.Dtos.EpisodeCompanionDto>(MemberList.Source)
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
        }
    }
}
