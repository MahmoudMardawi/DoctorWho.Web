using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Profiles
{
    internal class EnemyProfile : Profile
    {
        public EnemyProfile()
        {
            this.CreateMap<DoctorWho.Db.Domain.Models.Enemy,
                DoctorWho.Db.Domain.Dtos.EnemyDto>(MemberList.Source);

        }
    }
}
