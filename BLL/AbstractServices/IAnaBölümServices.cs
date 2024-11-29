using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AbstractServices
{
    public interface IAnaBölümServices
    {
        void AddAnaBölüm(AnaBölümDTO anaBölümDTO);
        void UpdateAnaBölüm(AnaBölümDTO anaBölümDTO, int Id);
        void DeleteAnaBölüm(int Id);
        List<YöneticiDTO> GetAllAnaBölüm();
    }
}
