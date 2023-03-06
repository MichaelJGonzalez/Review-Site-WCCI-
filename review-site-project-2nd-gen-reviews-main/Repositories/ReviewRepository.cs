using Microsoft.EntityFrameworkCore;
using Review_Site_Sok_Michael.Models;

namespace Review_Site_Sok_Michael.Repositories
{
    public class ReviewRepository : IRepository<ReviewModel>
    {
        private readonly ShoesContext context;
        public ReviewRepository(ShoesContext context)
        {
            this.context = context;
        }

        public void Create(ReviewModel entity)
        {
            context.Reviews.Add(entity);
            context.SaveChanges();
        }

        public void Delete(ReviewModel entity)
        {
            context.Reviews.Remove(entity);
            context.SaveChanges();
        }
        public List<ReviewModel> Find(string name)
        {
            return context.Reviews.Where(i => i.Name.ToUpper() == name.ToUpper()).ToList();
        }

        public IEnumerable<ReviewModel> GetAll()
        {
            return context.Reviews.Include(j => j.Jordans).ToList();

        }

        public ReviewModel GetByID(int id)
        {
            return context.Reviews.Where(i => i.Id == id).FirstOrDefault();
        }
        public void Update(ReviewModel entity)
        {
            context.Reviews.Add(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Edit(ReviewModel entity)
        {
            context.Reviews.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public List<JordansModel> JordansList()
        {
            return context.Jordans.ToList();
        }
    }
}
