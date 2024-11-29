using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.AbstractRepository
{
    public interface IGenericRepository<T> where T : BaseClass    
    {
        void Add(T entity);
        void Update(T entity,int Id);
        void Delete(int Id);
        List<T> GetAll();
        T GetById(int id);
    }
}
