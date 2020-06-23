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
        public void SeedHinhAnhSanPham()
        {
            // iPhone 11 Pro Max 512GB
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 1,
                HinhAnhSanPhamId = 1,
                ImagePath = "images/iphone-11-pro-max-512gb-gold-400x460.png"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 1,
                HinhAnhSanPhamId = 2,
                ImagePath = "images/iphone-11-pro-max-512gb-xanh-1-org.jpg"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 1,
                HinhAnhSanPhamId = 3,
                ImagePath = "images/iphone-11-pro-max-512gb-xam-5-org.jpg"
            });

            // iPhone 6s Plus 32GB
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 2,
                HinhAnhSanPhamId = 4,
                ImagePath = "images/iphone-6s-plus-32gb-rose-gold-400x460.png"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 2,
                HinhAnhSanPhamId = 5,
                ImagePath = "images/iphone-6s-plus-32gb-vanghong1-2-org.jpg"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 2,
                HinhAnhSanPhamId = 6,
                ImagePath = "images/iphone-6s-plus-32gb-vanghong1-3-org.jpg"
            });

            // Samsung Galaxy S10+
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 3,
                HinhAnhSanPhamId = 7,
                ImagePath = "images/sieu-pham-galaxy-s-moi-2-512gb-black-400x460.png"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 3,
                HinhAnhSanPhamId = 8,
                ImagePath = "images/samsung-galaxy-s10-plus-512gb-den-2-1-org.jpg"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 3,
                HinhAnhSanPhamId = 9,
                ImagePath = "images/samsung-galaxy-s10-plus-512gb-den-3-2-org.jpg"
            });

            // Samsung Galaxy A10
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 4,
                HinhAnhSanPhamId = 10,
                ImagePath = "images/samsung-galaxy-a10-red-400x460.png"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 4,
                HinhAnhSanPhamId = 11,
                ImagePath = "images/samsung-galaxy-a10-do-2-org.jpg"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 4,
                HinhAnhSanPhamId = 12,
                ImagePath = "images/samsung-galaxy-a10-do-3-org.jpg"
            });

            // OPPO Reno 10x Zoom Edition
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 5,
                HinhAnhSanPhamId = 13,
                ImagePath = "images/oppo-reno-10x-zoom-edition-black-400x460.png"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 5,
                HinhAnhSanPhamId = 14,
                ImagePath = "images/oppo-reno-10x-zoom-edition-den-2-org.jpg"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 5,
                HinhAnhSanPhamId = 15,
                ImagePath = "images/oppo-reno-10x-zoom-edition-den-3-org.jpg"
            });

            // OPPO A1K
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 6,
                HinhAnhSanPhamId = 16,
                ImagePath = "images/oppo-a1k-red-400x460.png"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 6,
                HinhAnhSanPhamId = 17,
                ImagePath = "images/oppo-a1k-do-2-org.jpg"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 6,
                HinhAnhSanPhamId = 18,
                ImagePath = "images/oppo-a1k-do-3-org.jpg"
            });

            // Huawei P30 Pro
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 7,
                HinhAnhSanPhamId = 19,
                ImagePath = "images/huawei-p30-pro-1-400x460.png"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 7,
                HinhAnhSanPhamId = 20,
                ImagePath = "images/huawei-p30-pro-xanh-duong-2-org.jpg"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 7,
                HinhAnhSanPhamId = 21,
                ImagePath = "images/huawei-p30-pro-xanh-duong-3-org.jpg"
            });

            // Huawei Y7 Pro (2019)
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 8,
                HinhAnhSanPhamId = 22,
                ImagePath = "images/huawei-y7-pro-2019-400x460.png"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 8,
                HinhAnhSanPhamId = 23,
                ImagePath = "images/huawei-y7-pro-2019-xanh-duong-2-org.jpg"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 8,
                HinhAnhSanPhamId = 24,
                ImagePath = "images/huawei-y7-pro-2019-xanh-duong-3-org.jpg"
            });

            // iPad Pro 11 inch Wifi 64GB (2018)
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 9,
                HinhAnhSanPhamId = 25,
                ImagePath = "images/ipad-pro-11-inch-2018-64gb-wifi-33397-chitiet-400x460.png"
            });

            // iPad Wifi 32GB (2018)
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 10,
                HinhAnhSanPhamId = 26,
                ImagePath = "images/ipad-6th-wifi-32gb-1-400x460.png"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 10,
                HinhAnhSanPhamId = 27,
                ImagePath = "images/ipad-wifi-32gb-2018-mau-bac-3-org.jpg"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 10,
                HinhAnhSanPhamId = 28,
                ImagePath = "images/ipad-wifi-32gb-2018-mau-bac-1-org.jpg"
            });

            // Samsung Galaxy Tab S6
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 11,
                HinhAnhSanPhamId = 29,
                ImagePath = "images/samsung-galaxy-tab-s6-400x460.png"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 11,
                HinhAnhSanPhamId = 30,
                ImagePath = "images/samsung-galaxy-tab-s6-xanh-duong-2-org.jpg"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 11,
                HinhAnhSanPhamId = 31,
                ImagePath = "images/samsung-galaxy-tab-s6-xanh-duong-3-org.jpg"
            });

            // Samsung Galaxy Tab A8 8" T295 (2019)
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 12,
                HinhAnhSanPhamId = 32,
                ImagePath = "images/samsung-galaxy-tab-a8-t295-2019-silver-400x460.png"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 12,
                HinhAnhSanPhamId = 33,
                ImagePath = "images/samsung-galaxy-tab-a8-t295-2019-bac-2-org.jpg"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 12,
                HinhAnhSanPhamId = 34,
                ImagePath = "images/samsung-galaxy-tab-a8-t295-2019-bac-3-org.jpg"
            });

            // laptop  acer nitro 5
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 13,
                HinhAnhSanPhamId = 34,
                ImagePath = "images/acernitro-5.jpg"
            });
            //asus vivobook
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 14,
                HinhAnhSanPhamId = 35,
                ImagePath = "images/asus-vivobook.png"
            });
            //lenovo joga
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 15,
                HinhAnhSanPhamId = 36,
                ImagePath = "images/lenovo-joga.jpg"
            });
            //acer predator triton
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 16,
                HinhAnhSanPhamId = 37,
                ImagePath = "images/acer-predator-triton.jpg"
            });
            //lenovo legion
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 17,
                HinhAnhSanPhamId = 38,
                ImagePath = "images/lenovo-legion.jpg"
            });
            //Apple macbook pro
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 18,
                HinhAnhSanPhamId = 39,
                ImagePath = "images/laptop-apple macbook-pro.jpg"
            });
            //Ipad mini wifi 2019
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 19,
                HinhAnhSanPhamId = 40,
                ImagePath = "images/ipad-mini-79-inch-wifi-2019-gold.png"
            });
            //Laptop dell
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 20,
                HinhAnhSanPhamId = 41,
                ImagePath = "images/dell-g7-7588.jpg"
            });
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 21,
                HinhAnhSanPhamId = 42,
                ImagePath = "images/DellG3.png"
            });
            //Ipad SFGO10
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 22,
                HinhAnhSanPhamId = 43,
                ImagePath = "images/SF-GO-10.jpg"
            });

            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 23,
                HinhAnhSanPhamId = 44,
                ImagePath = "images/surface-3.jpg"
            });

            //Linh Kiện
            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 24,
                HinhAnhSanPhamId = 45,
                ImagePath = "images/CMHasusTUF.jpg"
            });

            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 25,
                HinhAnhSanPhamId = 46,
                ImagePath = "images/MainboardASRock.jpg"
            });


            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 26,
                HinhAnhSanPhamId = 47,
                ImagePath = "images/ramhyperxfury32.jpg"
            });

            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 27,
                HinhAnhSanPhamId = 48,
                ImagePath = "images/cpucorei79700.jpg"
            });

            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 28,
                HinhAnhSanPhamId = 49,
                ImagePath = "images/nguongoldenfield.jpg"
            });

            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 29,
                HinhAnhSanPhamId = 50,
                ImagePath = "images/tannhietcpuaiocooler.jpg"
            });

            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 30,
                HinhAnhSanPhamId = 51,
                ImagePath = "images/ssdsamsung860.jpg"
            });

            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 31,
                HinhAnhSanPhamId = 52,
                ImagePath = "images/caseasusrog.jpg"
            });

            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 32,
                HinhAnhSanPhamId = 53,
                ImagePath = "images/pinasusul20.jpg"
            });

            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 33,
                HinhAnhSanPhamId = 54,
                ImagePath = "images/capnguoncooler.jpg"
            });

            context_.HinhAnhSanPhamContext.AddOrUpdate(new HinhAnhSanPham()
            {
                SanPhamId = 34,
                HinhAnhSanPhamId = 55,
                ImagePath = "images/banphimco.jpg"
            });
            context_.SaveChanges();
        }
    }
}