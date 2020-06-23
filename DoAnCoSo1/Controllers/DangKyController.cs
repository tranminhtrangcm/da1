﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BCrypt.Net;
using DoAnCoSo1.Models;

namespace DoAnCoSo1.Controllers
{
    public class FormDangKy {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
    }

    public class DangKyController : Controller
    {
        private DoAnCoSo1DBContext context = new DoAnCoSo1DBContext();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.form = new FormDangKy { Username = "", Email="" };
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormDangKy form)
        {
            ViewBag.form = form;
            return Redirect("/admin");
        }
	}
}