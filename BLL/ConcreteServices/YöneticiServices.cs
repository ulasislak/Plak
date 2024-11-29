using AutoMapper;
using BLL.AbstractServices;
using DAL.ConcreteRepository;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ConcreteServices
{
    public class YöneticiServices : IYonetıcıServices
    {
        private readonly GenericRepository<Yönetici> _genericRepository;
        private readonly IMapper _mapper;

        public YöneticiServices(GenericRepository<Yönetici> genericRepository,IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }
        public void AddYonetici(YöneticiDTO yöneticiDTO)
        {
            _genericRepository.Add(_mapper.Map<Yönetici>(yöneticiDTO));
        }
        public void DeleteYonetici(int Id)
        {
            _genericRepository.Delete(Id);
        }
        public List<YöneticiDTO> GetAllYonetici()
        {
            return _mapper.Map<List<YöneticiDTO>>(_genericRepository.GetAll());
        }       
        public void UpdateYonetici(YöneticiDTO yöneticiDTO, int Id)
        {
            _genericRepository.Update(_mapper.Map<Yönetici>(yöneticiDTO), Id);
        }
    }
}
