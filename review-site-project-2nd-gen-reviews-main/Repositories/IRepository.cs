using Review_Site_Sok_Michael.Models;

namespace Review_Site_Sok_Michael.Repositories
{
    public interface IRepository<T>
    {
        void Create(T entity);
        void Delete(T entity);
        List<T> Find(string name);
        IEnumerable<T> GetAll();
        T GetByID(int id);
        void Update(T entity);
        void Edit(T entity);
        List<JordansModel> JordansList();
    }
}