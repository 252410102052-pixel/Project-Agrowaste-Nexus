using System.Collections.Generic;

namespace AgroWasteNexus.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}