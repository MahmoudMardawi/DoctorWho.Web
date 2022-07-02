using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Profiles
{
    internal class EpisodeEnemyProfile : Profile
    {
        public EpisodeEnemyProfile()
        {
            this.CreateMap<DoctorWho.Db.Domain.Models.EpisodeEnemy,
                DoctorWho.Db.Domain.Dtos.EpisodeEnemyDto>(MemberList.Source)
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
        }
    }
}
