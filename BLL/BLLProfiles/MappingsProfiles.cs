using AutoMapper;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLProfiles
{
    public class MappingsProfiles:Profile
    {
        public MappingsProfiles()
        {
            CreateMap<BaseClassDTO,BaseClass>().ReverseMap();
            CreateMap<AnaBölümDTO,AnaBölüm>().ReverseMap();
            CreateMap<YöneticiDTO,Yönetici>().ReverseMap();
            CreateMap<YöneticiAnaBölümDTO, YöneticiAnaBölüm>()
                .ForMember(a => a.AnaBölüm, b => b.MapFrom(c => c.AnaBölüm))
                .ForMember(d => d.Yönetici, e => e.MapFrom(c => c.Yönetici)).ReverseMap();
        }
    }
}
