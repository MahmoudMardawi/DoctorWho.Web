using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorWho.Db.Domain.Dtos;
using DoctorWho.Db.Domain.Models;

namespace DoctorWho.Db.Profiles
{
    public class DoctorProfile : Profile
    {
        public DoctorProfile()
        {
            this.CreateMap<Doctor, DoctorDto>(MemberList.Source)
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter();

        }
    }
}
