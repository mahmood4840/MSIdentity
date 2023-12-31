﻿using AspNetIdentity.Core.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetIdentity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICompanyService _companyService;
        public HomeController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}