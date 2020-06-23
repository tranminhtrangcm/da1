using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DoAnCoSo1.Models
{
    public class DoAnCoSo1DBContext : DbContext
    {
        public DoAnCoSo1DBContext()
            : base("DoAnCoSo1DB")
        {
        }

        public DbSet<SanPham> SanPhamContext { get; set; }
        public DbSet<LoaiSanPham> LoaiSanPhamContext { get; set; }
        public DbSet<HangSanXuat> HangSanXuatContext { get; set; }
        public DbSet<CauHinhSanPham> CauHinhSanPhamContext { get; set; }
        public DbSet<HinhAnhSanPham> HinhAnhSanPhamContext { get; set; }
        public DbSet<KhuyenMai> KhuyenMaiContext { get; set; }
        public DbSet<TaiKhoan> TaiKhoanContext { get; set; }
        public DbSet<DonHang> DonHangContext { get; set; }
    }
}