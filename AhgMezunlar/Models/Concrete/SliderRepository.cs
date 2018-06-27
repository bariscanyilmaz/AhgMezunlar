using AhgMezunlar.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhgMezunlar.Models.Concrete
{
    public class SliderRepository : ISliderRepository
    {
        private ApplicationDbContext dbContext;
        public SliderRepository(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public void AddSliderIamge(SliderImage sliderImage)
        {
            dbContext.SliderImages.Add(sliderImage);
            dbContext.SaveChanges();
        }

        public void DeleteSliderImage(int id)
        { var image = dbContext.SliderImages.FirstOrDefault(s => s.Id == id);
            dbContext.SliderImages.Remove(image);
        }

        public IQueryable<SliderImage> GetSliderImages()
        {
            return dbContext.SliderImages;  
        }
    }
}
