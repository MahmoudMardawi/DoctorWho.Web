using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Profiles
{
    internal class EpisodeProfile : Profile
    {
        public EpisodeProfile()
        {
            this.CreateMap<DoctorWho.Db.Domain.Models.Episode,
                DoctorWho.Db.Domain.Dtos.EpisodeDto>(MemberList.Source)
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
        }
    }
}
