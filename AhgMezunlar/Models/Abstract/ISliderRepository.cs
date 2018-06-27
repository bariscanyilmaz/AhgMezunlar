using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhgMezunlar.Models.Abstract
{
    public interface ISliderRepository
    {
        IQueryable<SliderImage> GetSliderImages();
        void AddSliderIamge(SliderImage sliderImage);
        void DeleteSliderImage(int id);
    }
}
