using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAnCoSo1.Repositories;

namespace DoAnCoSo1.Controllers
{
    public class LaptopController : Controller
    {
        
        public ActionResult Index()
        {
            ViewData["ListSanPham"] = SanPhamRepo.LoadListSanPham("Laptop");

            return View();
        }
    }
}