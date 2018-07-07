using AhgMezunlar.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhgMezunlar.Models.Concrete
{
    public class MomentsRepository : IMomentsRepository
    {
        private ApplicationDbContext dbContext;
        public MomentsRepository(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public void AddMoment(Moments moment)
        {
            dbContext.Moments.Add(moment);
            dbContext.SaveChanges();
        }

        public void DeleteMoment(int momentId)
        {
            var blog = dbContext.Moments.FirstOrDefault(m => m.Id == momentId);
            if (blog!=null)
            {
                dbContext.Moments.Remove(blog);
                dbContext.SaveChanges();
            }
        }

        public Moments GetMoment(int id)
        {
            return dbContext.Moments.SingleOrDefault(m => m.Id == id);
        }

        public IQueryable<Moments> GetMoments()
        {
            return dbContext.Moments;
        }

        public void UpdateMoment(bool show,int momentId)
        {
            var blog = dbContext.Moments.FirstOrDefault(m => m.Id == momentId);
            if (blog!=null)
            {
                blog.ShowState = show;
                dbContext.SaveChanges();
            }
        }
    }
}
