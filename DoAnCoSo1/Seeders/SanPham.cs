using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoAnCoSo1.Models;
using System.Data.Entity.Migrations;

namespace DoAnCoSo1.Seeders
{
    public partial class Seeder
    {
        public void SeedSanPham()
        {
            // Điện thoại
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 1, TenSanPham = "iPhone 11 Pro Max 512GB", GiaNhapHang = 43000000, GiaBan = 43990000, LoaiSanPhamId = 1, HangSanXuatId = 1, HienThiTrangChu = true, ImgDaiDien = "images/iphone-11-pro-max-512gb-gold-400x460.png", SoLuongKho = 1 });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 2, TenSanPham = "iPhone 6s Plus 32GB", GiaNhapHang = 8000000, GiaBan = 8990000, LoaiSanPhamId = 1, HangSanXuatId = 1, HienThiTrangChu = true, ImgDaiDien = "images/iphone-6s-plus-32gb-rose-gold-400x460.png" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 3, TenSanPham = "Samsung Galaxy S10+", GiaNhapHang = 28000000, GiaBan = 28990000, LoaiSanPhamId = 1, HangSanXuatId = 2, HienThiTrangChu = true, ImgDaiDien = "images/sieu-pham-galaxy-s-moi-2-512gb-black-400x460.png", SoLuongKho = 1 });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 4, TenSanPham = "Samsung Galaxy A10", GiaNhapHang = 3000000, GiaBan = 3090000, LoaiSanPhamId = 1, HangSanXuatId = 2, ImgDaiDien = "images/samsung-galaxy-a10-red-400x460.png" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 5, TenSanPham = "OPPO Reno 10x Zoom Edition", GiaNhapHang = 20000000, GiaBan = 20990000, LoaiSanPhamId = 1, HangSanXuatId = 3, HienThiTrangChu = true, ImgDaiDien = "images/oppo-reno-10x-zoom-edition-black-400x460.png", SoLuongKho = 1 });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 6, TenSanPham = "OPPO A1K", GiaNhapHang = 3100000, GiaBan = 3190000, LoaiSanPhamId = 1, HangSanXuatId = 3, ImgDaiDien = "images/oppo-a1k-red-400x460.png" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 7, TenSanPham = "Huawei P30 Pro", GiaNhapHang = 22000000, GiaBan = 22990000, LoaiSanPhamId = 1, HangSanXuatId = 4, HienThiTrangChu = true, ImgDaiDien = "images/huawei-p30-pro-1-400x460.png", SoLuongKho = 1 });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 8, TenSanPham = "Huawei Y7 Pro (2019)", GiaNhapHang = 3400000, GiaBan = 3490000, LoaiSanPhamId = 1, HangSanXuatId = 4, ImgDaiDien = "images/huawei-y7-pro-2019-400x460.png" });

            // Máy tính bảng
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 9, TenSanPham = "iPad Pro 11 inch Wifi 64GB (2018)", GiaNhapHang = 21000000, GiaBan = 21990000, LoaiSanPhamId = 2, HangSanXuatId = 1, HienThiTrangChu = true, ImgDaiDien = "images/ipad-pro-11-inch-2018-64gb-wifi-33397-chitiet-400x460.png" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 10, TenSanPham = "iPad Wifi 32GB (2018)", GiaNhapHang = 7000000, GiaBan = 7990000, LoaiSanPhamId = 2, HangSanXuatId = 1, HienThiTrangChu = true, ImgDaiDien = "images/ipad-6th-wifi-32gb-1-400x460.png" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 11, TenSanPham = "Samsung Galaxy Tab S6", GiaNhapHang = 18400000, GiaBan = 18490000, LoaiSanPhamId = 2, HangSanXuatId = 2, HienThiTrangChu = true, ImgDaiDien = "images/samsung-galaxy-tab-s6-400x460.png" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 12, TenSanPham = "Samsung Galaxy Tab A8 8\" T295 (2019)", GiaNhapHang = 3600000, GiaBan = 3690000, LoaiSanPhamId = 2, HangSanXuatId = 2,  ImgDaiDien = "images/samsung-galaxy-tab-a8-t295-2019-silver-400x460.png" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 19, TenSanPham = " iPad Mini 7.9 inch Wifi 64GB", GiaNhapHang = 9600000, GiaBan = 10490000, LoaiSanPhamId = 2, HangSanXuatId = 2, HienThiTrangChu = true, ImgDaiDien = "images/ipad-mini-79-inch-wifi-2019-gold.png" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 22, TenSanPham = " Microsoft Surface Go 10'", GiaNhapHang = 10000000, GiaBan = 11900000, LoaiSanPhamId = 2, HangSanXuatId = 8 , HienThiTrangChu = true, ImgDaiDien = "images/SF-GO-10.jpg" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 23, TenSanPham = " Surface 3'", GiaNhapHang = 6040000, GiaBan = 8500000, LoaiSanPhamId = 2, HangSanXuatId = 8,  ImgDaiDien = "images/surface-3.jpg" });

            //Laptop
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 13, TenSanPham = "Laptop Acer Nitro 5 AN515-54-51X1 (NH.Q5ASV.011)", GiaNhapHang = 36000000, GiaBan = 36900000, LoaiSanPhamId = 3, HangSanXuatId = 5, HienThiTrangChu = true, ImgDaiDien = "images/acernitro-5.jpg" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 14, TenSanPham = "Laptop ASUS VivoBook X407MA-BV169T", GiaNhapHang = 6000000, GiaBan = 7690000, LoaiSanPhamId = 3, HangSanXuatId = 6, ImgDaiDien = "images/asus-vivobook.png" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 15, TenSanPham = "Laptop Lenovo Yoga S740-14IIL-81RS0036VN", GiaNhapHang = 20000000, GiaBan = 23990000, LoaiSanPhamId = 3, HangSanXuatId = 6, HienThiTrangChu = true, ImgDaiDien = "images/lenovo-joga.jpg" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 16, TenSanPham = "Laptop Acer Predator Triton 500 PT515-52-72U2 (NH.Q6WSV.001) (i7-10875H) (Đen)", GiaNhapHang = 70000000, GiaBan = 79990000, LoaiSanPhamId = 3, HangSanXuatId = 5, HienThiTrangChu = true, ImgDaiDien = "images/acer-predator-triton.jpg" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 17, TenSanPham = "Laptop Lenovo Legion Y740-81HE003XVN", GiaNhapHang = 44000000, GiaBan = 46990000, LoaiSanPhamId = 3, HangSanXuatId = 6, HienThiTrangChu = true, ImgDaiDien = "images/lenovo-legion.jpg" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 18, TenSanPham = "Laptop Apple Macbook Pro 2018 13.3' MR9Q2", GiaNhapHang = 40000000, GiaBan = 44990000, LoaiSanPhamId = 3, HangSanXuatId = 1, HienThiTrangChu = true, ImgDaiDien = "images/laptop-apple macbook-pro.jpg" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 20, TenSanPham = "Laptop Dell G7 7588-N7588A", GiaNhapHang = 29000000, GiaBan = 30790000, LoaiSanPhamId = 3, HangSanXuatId = 7, ImgDaiDien = "images/dell-g7-7588.jpg" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 21, TenSanPham = "Laptop Dell G3 15 3590-N5I5517W", GiaNhapHang = 20000000, GiaBan = 22090000, LoaiSanPhamId = 3, HangSanXuatId = 7, ImgDaiDien = "images/DellG3.png" });

            //Linh Kiện
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 24, TenSanPham = "Card màn hình ASUS TUF Gaming", GiaNhapHang = 10000000, GiaBan = 11490000, LoaiSanPhamId = 4, HangSanXuatId = 6, HienThiTrangChu = true, ImgDaiDien = "images/CMHasusTUF.jpg" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 25, TenSanPham = "Mainboard ASRock Z390 Steel Legend", GiaNhapHang = 100000, GiaBan = 3890000, LoaiSanPhamId = 4, HangSanXuatId = 6, HienThiTrangChu = true, ImgDaiDien = "images/MainboardASRock.jpg" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 26, TenSanPham = "RAM desktop KINGSTON HyperX Fury RGB 32GB DDR4 3200MHz", GiaNhapHang = 700000, GiaBan = 4690000, LoaiSanPhamId = 4, HangSanXuatId = 6, HienThiTrangChu = true, ImgDaiDien = "images/ramhyperxfury32.jpg" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 27, TenSanPham = "CPU INTEL Core i7-9700 (8C/8T, 3.00 GHz up to 4.70 GHz, 12MB) - 1151-v2", GiaNhapHang = 8000000, GiaBan = 8970000, LoaiSanPhamId = 4, HangSanXuatId = 6,  ImgDaiDien = "images/cpucorei79700.jpg" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 28, TenSanPham = "Nguồn máy tính Golden Field Dragon GTX680 600W", GiaNhapHang = 800000, GiaBan = 970000, LoaiSanPhamId = 4, HangSanXuatId = 6, ImgDaiDien = "images/nguongoldenfield.jpg" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 29, TenSanPham = "Tản nhiệt CPU AIO Cooler Master Masterliquid ML240P Mirage", GiaNhapHang = 3000000, GiaBan = 3840000, LoaiSanPhamId = 4, HangSanXuatId = 6, HienThiTrangChu = true, ImgDaiDien = "images/tannhietcpuaiocooler.jpg" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 30, TenSanPham = "Ổ cứng SSD Samsung 860 EVO 1TB M.2 Sata (Mz-N6E1T0BW)", GiaNhapHang = 4000000, GiaBan = 4840000, LoaiSanPhamId = 4, HangSanXuatId = 2,  ImgDaiDien = "images/ssdsamsung860.jpg" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 31, TenSanPham = "Case máy tính ASUS ROG Strix Helios - Mid Tower (Đen)", GiaNhapHang = 6000000, GiaBan = 6900000, LoaiSanPhamId = 4, HangSanXuatId = 6, HienThiTrangChu = true, ImgDaiDien = "images/caseasusrog.jpg" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 32, TenSanPham = "Pin dùng cho laptop Asus UL20", GiaNhapHang = 600000, GiaBan = 667000, LoaiSanPhamId = 4, HangSanXuatId = 6, ImgDaiDien = "images/pinasusul20.jpg" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 33, TenSanPham = "Cáp Nối Nguồn Cooler Master Sleeved Extension CMA-SEST16RDBK1-GL (Đỏ Đen)", GiaNhapHang = 600000, GiaBan = 670000, LoaiSanPhamId = 4, HangSanXuatId = 6, ImgDaiDien = "images/capnguoncooler.jpg" });
            context_.SanPhamContext.AddOrUpdate(new SanPham() { SanPhamId = 34, TenSanPham = "Bàn phím cơ Razer Huntsman Elite (RZ03-01870100-R3M1) (Full size/Razer Opto/RGB)", GiaNhapHang = 5000000, GiaBan = 5499000, LoaiSanPhamId = 4, HangSanXuatId = 6, ImgDaiDien = "images/banphimco.jpg" });
            context_.SaveChanges();
        }
    }
}