using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace batchmailr
{
    public interface IRepository<T> where T : class
    {
        public IEnumerable<T> GetAllItems();
    }

    public class Repository<T> : IRepository<T> where T : class
    {
        private DbSet<T> _entity;

        public Repository(ApplicationDbContext applicationDbContext)
        {
            _entity = applicationDbContext.Set<T>();
        }

        public IEnumerable<T> GetAllItems()
        {
            return _entity.ToList();
        }
    }
}
