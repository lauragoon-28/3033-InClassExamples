﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Example.Controllers
{
    public class OUController : Controller
    {
        // GET: OU
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TAs()
        {
            List<Student> tas = new List<Student>()
            {
                new Student()
                {
                    FirstName = "Micah",
                    LastName = "Tison",
                    SoonerID = '5'

                },
                new Student()
                {
                    FirstName = "Talia",
                    LastName = "Dean",
                    SoonerID = '8'

                }
            };

            return View(tas);
        }
    }
}