﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AhgMezunlar.Controllers
{
    public class MomentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}