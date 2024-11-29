using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AbstractServices
{
    public interface IYonetıcıServices
    {
        void AddYonetici(YöneticiDTO yöneticiDTO);
        void UpdateYonetici(YöneticiDTO yöneticiDTO, int Id);
        void DeleteYonetici(int Id);
        List<YöneticiDTO> GetAllYonetici();
      
    }
}
