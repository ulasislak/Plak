using AutoMapper;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.UIProifles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<BaseClassViewModel, BaseClassDTO>().ReverseMap();
            CreateMap<AnaBölümViewModel, AnaBölümDTO>().ReverseMap();
            CreateMap<YöneticiViewModel, YöneticiDTO>().ReverseMap();
            CreateMap<YöneticiAnaBölümViewModel, YöneticiAnaBölümDTO>()
                .ForMember(a => a.AnaBölüm, b => b.MapFrom(c => c.AnaBölüm))
                .ForMember(d => d.Yönetici, e => e.MapFrom(c => c.Yönetici)).ReverseMap();
        }
    }
}
