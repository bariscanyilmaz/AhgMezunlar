using AhgMezunlar.Models.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhgMezunlar.ViewComponents
{
    public class MomentsViewComponent:ViewComponent
    {
        private IMomentsRepository momentsRepository;

        public MomentsViewComponent(IMomentsRepository _momentsRepository)
        {
            momentsRepository = _momentsRepository;
        }

        public IViewComponentResult Invoke()
        {
            return View(momentsRepository.GetMoments().Where(m=>m.ShowState==true));
        }
    }
}
