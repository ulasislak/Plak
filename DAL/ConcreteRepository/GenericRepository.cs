using DAL.AbstractRepository;
using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ConcreteRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseClass
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _entities;


        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public void Add(T entity)
        {
            _entities.Add(entity);
            _context.SaveChanges();
        }
        
        public void Delete(int Id)
        {
            var DeleteEntity=GetById(Id);
            _entities.Remove(DeleteEntity);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _entities.ToList();
        }

        public T GetById(int id)
        {
            return _entities.FirstOrDefault(x=>x.Id==id);    
        }

        public void Update(T entity, int Id)
        {
            var existingEntity = _entities.Find(Id);
            if (existingEntity != null)
            {
                // Context'e entity'nin değiştiğini bildir
                _context.Entry(existingEntity).CurrentValues.SetValues(entity);
                _context.SaveChanges();
            }
        }
    }
}
