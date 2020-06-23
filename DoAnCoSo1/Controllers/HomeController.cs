using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAnCoSo1.Repositories;
using DoAnCoSo1.Models;

namespace DoAnCoSo1.Controllers
{
    public class HomeController : Controller
    {
        DoAnCoSo1DBContext db = new DoAnCoSo1DBContext();

        public ActionResult Index()
        {
            if (Request.QueryString["search"] != null && Request.QueryString["search"].Trim() != "")
                return Redirect("/ketquatimkiem?search=" + Request.QueryString["search"].Trim());

            ViewData["listDienThoai"] = SanPhamRepo.LoadListSanPham("Điện thoại").Where(sp => sp.HienThiTrangChu == true).ToList();
            ViewData["listMayTinhBang"] = SanPhamRepo.LoadListSanPham("Máy tính bảng").Where(sp => sp.HienThiTrangChu == true).ToList();
            ViewData["listLaptop"] = SanPhamRepo.LoadListSanPham("Laptop").Where(sp => sp.HienThiTrangChu == true).ToList();
            ViewData["listLinhKien"] = SanPhamRepo.LoadListSanPham("Linh Kiện").Where(sp => sp.HienThiTrangChu == true).ToList();
            return View();
        }

        [HttpGet]
        [Route("ketquatimkiem")]
        public ActionResult KetQuaTimKiem()
        {
            string search = Request.QueryString["search"].ToLower();

            var listSanPham = db.SanPhamContext.Where(sp => sp.TenSanPham.ToLower().IndexOf(search) >= 0).ToList();
            var listDienThoai = listSanPham.Where(sp => sp.LoaiSanPham.TenLoaiSanPham == "Điện thoại").ToList();
            var listMayTinhBang = listSanPham.Where(sp => sp.LoaiSanPham.TenLoaiSanPham == "Máy tính bảng").ToList();
            var listLaptop = listSanPham.Where(sp => sp.LoaiSanPham.TenLoaiSanPham == "Laptop").ToList();
            var listLinhKien = listSanPham.Where(sp => sp.LoaiSanPham.TenLoaiSanPham == "Linh Kiện").ToList();

            ViewData["ListDienThoai"] = listDienThoai;
            ViewData["ListMayTinhBang"] = listMayTinhBang;
            ViewData["ListLaptop"] = listLaptop;
            ViewData["ListLinhKien"] = listLinhKien;
            ViewBag.SoLuong = listSanPham.Count;
            ViewBag.SearchString = search;

            return View("KetQuaTimKiem");
        }
    }
}