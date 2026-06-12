using System.Collections.Generic;

namespace AgroWasteNexus.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T>
    {
        public abstract List<T> GetAll();
        public abstract void Insert(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(int id);
    }
}