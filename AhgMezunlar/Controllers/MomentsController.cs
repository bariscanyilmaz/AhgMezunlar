using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AhgMezunlar.Models.Abstract;
using AhgMezunlar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace AhgMezunlar.Controllers
{
    public class MomentsController : Controller
    {
        private IMomentsRepository momentsRepository;
        public MomentsController(IMomentsRepository _momentsRepository)
        {
            momentsRepository = _momentsRepository;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> AddMoment(Moments moment, IFormFile file)
        {
            try
            {
                if (file != null)
                {

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\Moments", file.FileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    moment.CoverPhotoPath = file.FileName;
                }

                momentsRepository.AddMoment(moment);

                ViewData["State"] = "Anınız onaylandıktan sonra yayınlanacaktır";

                return View("Index");
            }
            catch (Exception e)
            {
                ViewData["State"] = "Hata oluştu lütfen daha sonra tekrar deneyiniz";
                return View("Index");
            }

        }

       


    }
}