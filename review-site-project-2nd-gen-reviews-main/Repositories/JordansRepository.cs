using Microsoft.EntityFrameworkCore;
using Review_Site_Sok_Michael.Models;

namespace Review_Site_Sok_Michael.Repositories
{
    public class JordansRepository : IRepository<JordansModel>
    {
        private readonly ShoesContext context;

        public JordansRepository(ShoesContext context)
        {
            this.context = context;
        }
        public void Create(JordansModel entity)
        {
            context.Jordans.Add(entity);
            context.SaveChanges();
        }
        public void Delete(JordansModel entity)
        {
            context.Jordans.Remove(entity);
            context.SaveChanges();
        }
        public List<JordansModel> Find(string name)
        {
            return context.Jordans.Where(i => i.Name.ToUpper() == name.ToUpper()).ToList();
        }
        public IEnumerable<JordansModel> GetAll()
        {
            return context.Jordans.ToList();
        }

        public JordansModel GetByID(int id)
        {
            return context.Jordans.Where(i => i.Id == id).FirstOrDefault();
        }

        public void Update(JordansModel entity)
        {
            context.Jordans.Add(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Edit(JordansModel entity)
        {
            context.Jordans.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public List<JordansModel> JordansList()
        {
            throw new NotImplementedException();
        }
    }
}
