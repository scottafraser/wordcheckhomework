using System;
using Microsoft.AspNetCore.Mvc;
using WordCheck.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
                  
    {
        public class HomeController : Controller
        {

            [HttpGet("/")]
            public ActionResult Index()
            {
                return View();
            }
        }
    }
