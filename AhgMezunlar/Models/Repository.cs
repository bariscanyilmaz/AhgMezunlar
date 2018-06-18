using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhgMezunlar.Models
{
    public class Repository : IRepository
    {
        private ApplicationDbContext dbContext;

        public Repository(ApplicationDbContext context)
        {
            dbContext = context;
        }



        public Model Get()
        {
            return dbContext.Models.FirstOrDefault();
        }

       

    }
}
