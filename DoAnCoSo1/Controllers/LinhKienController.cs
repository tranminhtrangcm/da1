using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAnCoSo1.Repositories;

namespace DoAnCoSo1.Controllers
{
    public class LinhKienController : Controller
    {
       
        public ActionResult Index()
        {
            ViewData["ListSanPham"] = SanPhamRepo.LoadListSanPham("Linh Kiện");

            return View();
        }
	}
}