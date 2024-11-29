using AutoMapper;
using BLL.AbstractServices;
using DAL.ConcreteRepository;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ConcreteServices
{
    public class AnabölümServices : IAnaBölümServices
    {
        private readonly GenericRepository<AnaBölüm> _genericRepository;
        private readonly IMapper _mapper;

        public AnabölümServices(GenericRepository<AnaBölüm> genericRepository,IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }
        public void AddAnaBölüm(AnaBölümDTO anaBölümDTO)
        {
            _genericRepository.Add(_mapper.Map<AnaBölüm>(anaBölümDTO));
        }

        public void DeleteAnaBölüm(int Id)
        {
            _genericRepository.Delete(Id);
        }

        public List<YöneticiDTO> GetAllAnaBölüm()
        {
            return _mapper.Map<List<YöneticiDTO>>(_genericRepository.GetAll());
        }

        public void UpdateAnaBölüm(AnaBölümDTO anaBölümDTO, int Id)
        {
            _genericRepository.Update(_mapper.Map<AnaBölüm>(anaBölümDTO),Id);
        }
    }
}
