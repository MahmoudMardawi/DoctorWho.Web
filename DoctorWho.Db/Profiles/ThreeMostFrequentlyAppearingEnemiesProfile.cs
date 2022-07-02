using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace DoctorWho.Db.Domain.Profiles
{
    public class ThreeMostFrequentlyAppearingEnemiesProfile : Profile
    {
        public ThreeMostFrequentlyAppearingEnemiesProfile()
        {
            this.CreateMap<DoctorWho.Db.Domain.Models.ThreeMostFrequentlyAppearingEnemies
                , DoctorWho.Db.Domain.Dtos.ThreeMostFrequentlyAppearingEnemiesDto>(MemberList.Source);
        }
    }
}
