using AutoMapper;
using DoctorWho.Db.Domain.Dtos;
using DoctorWho.Db.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Profiles
{
    internal class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            this.CreateMap<Author, AuthorDto>(MemberList.Source)
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
            
        }
    }
}
