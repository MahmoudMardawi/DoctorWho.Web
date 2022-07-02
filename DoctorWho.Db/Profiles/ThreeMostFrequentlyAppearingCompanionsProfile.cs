using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.Profiles
{
    public class ThreeMostFrequentlyAppearingCompanionsProfile : Profile
    {
        public ThreeMostFrequentlyAppearingCompanionsProfile()
        {
            this.CreateMap<DoctorWho.Db.Domain.Models.ThreeMostFrequentlyAppearingCompanions
                , DoctorWho.Db.Domain.Dtos.ThreeMostFrequentlyAppearingCompanionsDto>(MemberList.Source);
        }
    }
}
