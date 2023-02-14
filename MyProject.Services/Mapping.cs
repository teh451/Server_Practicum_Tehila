using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyProject.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<Person, PersonDTO>()
                .ForMember(dest => dest.statusDTO, op => op.MapFrom(src => src.status))
                .ForMember(dest => dest.HMODTO, op => op.MapFrom(src => src.HMO))
                .ReverseMap();

            CreateMap<eStatus, eStatusDTO>().ReverseMap();
            CreateMap<eHMO, eHMODTO>().ReverseMap();
            CreateMap<Child, ChildDTO>().ReverseMap();
        }
    }
}
