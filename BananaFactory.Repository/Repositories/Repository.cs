using BananaFactory.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaFactory.Repository.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        protected readonly BananaFactoryDbContext context;
        private Microsoft.EntityFrameworkCore.DbSet<T> entities;
        string errorMessage = string.Empty;

        public Repository(BananaFactoryDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public void Remove(T item)
        {
            entities.Remove(item);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T GetById(int id)
        {
            return entities.Find(id);
        }

        public void Add(T entity)
        {
            entities.Add(entity);
        }

        public void Update(T entity)
        {
            entities.Update(entity);
        }
    }

    public interface IRepository<T> where T : BaseModel
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Remove(T item);
    }
}
