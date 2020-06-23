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
        public void SeedCauHinhSanPham()
        {
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 1,
                ManHinh = "OLED, 6.5\", Super Retina XDR",
                HeDieuHanh = "iOS 13",
                CameraTruoc = "12 MP",
                CameraSau = "3 camera 12 MP",
                Sim = "Nano SIM & eSIM, Hỗ trợ 4G",
                Pin = "3969 mAh, có sạc nhanh",
                CPU = "Apple A13 Bionic 6 nhân",
                GPU = "Apple GPU (4 nhân)",
                RAM = "4 GB",
                ROM = "512 GB"
            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 2,
                ManHinh = "LED-backlit IPS LCD, 5.5\", Retina HD",
                HeDieuHanh = "iOS 12",
                CameraTruoc = "5 MP",
                CameraSau = "12 MP",
                Sim = "1 Nano SIM, Hỗ trợ 4G",
                Pin = "2750 mAh",
                CPU = "Apple A9 2 nhân 64-bit",
                GPU = "PowerVR GT7600",
                RAM = "2 GB",
                ROM = "32 GB"
            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 3,
                ManHinh = "Dynamic AMOLED, 6.4\", Quad HD+ (2K+)",
                HeDieuHanh = "Android 9.0 (Pie)",
                CameraTruoc = "Chính 10 MP & Phụ 8 MP",
                CameraSau = "Chính 12 MP & Phụ 12 MP, 16 MP",
                Sim = "2 SIM Nano (SIM 2 chung khe thẻ nhớ), Hỗ trợ 4G",
                Pin = "4100 mAh, có sạc nhanh",
                CPU = "Exynos 9820 8 nhân 64-bit",
                GPU = "Mali-G76 MP12",
                RAM = "8 GB",
                ROM = "512 GB"
            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 4,
                ManHinh = "IPS LCD, 6.2\", HD+",
                HeDieuHanh = "Android 9.0 (Pie)",
                CameraTruoc = "5 MP",
                CameraSau = "13 MP",
                Sim = "2 Nano SIM, Hỗ trợ 4G",
                Pin = "3400 mAh",
                CPU = "Exynos 7884 8 nhân",
                GPU = "Mali-G71 MP2",
                RAM = "2 GB",
                ROM = "32 GB"
            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 5,
                ManHinh = "AMOLED, 6.6\", Full HD+",
                HeDieuHanh = "Android 9.0 (Pie)",
                CameraTruoc = "16 MP",
                CameraSau = "Chính 48 MP & Phụ 13 MP, 8 MP",
                Sim = "2 SIM Nano (SIM 2 chung khe thẻ nhớ), Hỗ trợ 4G",
                Pin = "4065 mAh, có sạc nhanh",
                CPU = "Snapdragon 855 8 nhân 64-bit",
                GPU = "Adreno 640",
                RAM = "8 GB",
                ROM = "256 GB"
            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 6,
                ManHinh = "IPS LCD, 6.1\", HD+",
                HeDieuHanh = "Android 9.0 (Pie)",
                CameraTruoc = "5 MP",
                CameraSau = "8 MP",
                Sim = "2 Nano SIM, Hỗ trợ 4G",
                Pin = "4000 mAh",
                CPU = "MediaTek MT6762R 8 nhân",
                GPU = "PowerVR GE8320",
                RAM = "2 GB",
                ROM = "32 GB"
            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 7,
                ManHinh = "OLED, 6.47\", Full HD+",
                HeDieuHanh = "Android 9.0 (Pie)",
                CameraTruoc = "32 MP",
                CameraSau = "Chính 40 MP & Phụ 20 MP, 8 MP, TOF 3D",
                Sim = "2 SIM Nano (SIM 2 chung khe thẻ nhớ), Hỗ trợ 4G",
                Pin = "4200 mAh, có sạc nhanh",
                CPU = "Hisilicon Kirin 980 8 nhân 64-bit",
                GPU = "Mali-G76 MP10",
                RAM = "8 GB",
                ROM = "256 GB"
            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 8,
                ManHinh = "IPS LCD, 6.26\", HD+",
                HeDieuHanh = "Android 8.1 (Oreo)",
                CameraTruoc = "16 MP",
                CameraSau = "Chính 13 MP & Phụ 2 MP",
                Sim = "2 Nano SIM, Hỗ trợ 4G",
                Pin = "4000 mAh",
                CPU = "Qualcomm Snapdragon 450 8 nhân 64-bit",
                GPU = "Adreno 506",
                RAM = "3 GB",
                ROM = "32 GB"
            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 9,
                ManHinh = "Liquid Retina, 11\"",
                HeDieuHanh = "iOS 12",
                CameraTruoc = "7 MP",
                CameraSau = "12 MP",
                Sim = "Không",
                Pin = "",
                CPU = "Apple A12X Bionic 64-bit",
                GPU = "",
                RAM = "4 GB",
                ROM = "64 GB"
            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 10,
                ManHinh = "LED backlit LCD, 9.7\"",
                HeDieuHanh = "iOS 12",
                CameraTruoc = "1.2 MP",
                CameraSau = "8 MP",
                Sim = "Không",
                Pin = "8600 mAh",
                CPU = "Apple A10 Fusion",
                GPU = "PowerVR Series 7",
                RAM = "2 GB",
                ROM = "32 GB"
            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 11,
                ManHinh = "Super AMOLED, 10.5\"",
                HeDieuHanh = "Android 9.0 (Pie)",
                CameraTruoc = "8 MP",
                CameraSau = "Chính 13 MP & Phụ 5 MP",
                Sim = "Nano Sim",
                Pin = "7040 mAh",
                CPU = "Qualcomm Snapdragon 855 8 nhân",
                GPU = "Adreno 640",
                RAM = "6 GB",
                ROM = "128 GB"
            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 12,
                ManHinh = "TFT LCD, 8\"",
                HeDieuHanh = "Android 9.0 (Pie)",
                CameraTruoc = "2 MP",
                CameraSau = "8 MP",
                Sim = "Nano Sim",
                Pin = "5100 mAh",
                CPU = "Qualcomm Snapdragon 429 processor, 4x2.0 GHz ARM Cortex A53",
                GPU = "Adreno 504",
                RAM = "2 GB",
                ROM = "32 GB"
            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 13,
                ManHinh = " 15.6' IPS(1920 x 1080)",
                HeDieuHanh = " Windows 10 Home 64-bit",
                CameraTruoc = "có",
                CameraSau = "",
                Sim = "Không",
                Pin = "4 cell 55 Wh Pin liền",
                CPU = "Intel Core i5 9300H",
                GPU = "",
                RAM = "1 x 8GB DDR4 2400MHz",
                ROM = "256GB SSD M.2 NVMe"
            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 14,
                ManHinh = " 14'(1366 x 768),không cảm ứng",
                HeDieuHanh = "  Windows 10 Home SL 64-bit",
                CameraTruoc = "có",
                CameraSau = "Không",
                Sim = "không",
                Pin = "3 cell 33 Wh Pin liền",
                CPU = "Intel Core i5 9300H",
                GPU = "Intel UHD Graphics 605",
                RAM = "1 x 4GB DDR4 2400MHz",
                ROM = "1TB HDD 5400RPM",
                TrongLuong = "1.7 kg",
                
            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 15,
                ManHinh = " 14' IPS(1920 x 1080)",
                HeDieuHanh = " Windows 10 Home SL 64-bit",
                CameraTruoc = "có",
                CameraSau = "Không",
                Sim = "Không",
                Pin = " 4 cell 62 Wh Pin liền",
                CPU = "Intel Core i5 9300H",
                GPU = "Intel Iris Plus Graphics",
                RAM = "8GB Onboard LPDDR4 3733MHz",
                ROM = "512GB SSD M.2 NVMe",
                TrongLuong = " 1.5 kg",

            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 16,
                ManHinh = " 15.6' (1920 x 1080), 300Hz",
                HeDieuHanh = "Windows 10 Home 64-bit",
                CameraTruoc = "Có",
                CameraSau = "Không",
                Sim = "Không",
                Pin = " 4 cell 62 Wh Pin liền",
                CPU = " Intel Core i7-10875H",
                GPU = "NVIDIA GeForce RTX 2080 Super 8GB GDDR6 / Intel UHD Graphics",
                RAM = "2 x 16GB DDR4 2933MHz",
                ROM = "1TB SSD M.2 NVMe",
                TrongLuong = " 2.1 kg",

            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 17,
                ManHinh = " 15.6' IPS ( 1920 x 1080 ) , không cảm ứng",
                HeDieuHanh = "Windows 10 Home 64-bit",
                CameraTruoc = "Có",
                CameraSau = "Không",
                Sim = "Không",
                Pin = " 3 cell 57 Wh Pin liền",
                CPU = "Intel Core i7-8750H ( 2.2 GHz - 4.1 GHz / 9MB / 6 nhân, 12 luồng )",
                GPU = "Intel UHD Graphics 630 / NVIDIA GeForce RTX 2060 6GB GDDR6",
                RAM = " 2 x 8GB DDR4 2666MHz",
                ROM = "128GB SSD M.2 NVMe / 1TB HDD 7200RPM",
                TrongLuong = " 2.3 kg",

            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 18,
                ManHinh = "13.3' ( 2560 x 1600 ) , không cảm ứng",
                HeDieuHanh = "macOS",
                CameraTruoc = "Có",
                CameraSau = "Không",
                Sim = "Không",
                Pin = " Pin liền",
                CPU = "Core i5 ( 2.3 GHz)",
                GPU = "Intel HD Graphics",
                RAM = "  8GB",
                ROM = "128GB SSD M.2 NVMe / 1TB HDD 7200RPM",
                TrongLuong = " 2.3 kg",

            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 19,
                ManHinh = "LED backlit LCD, 7.9'",
                HeDieuHanh = "IOS 12",
                CameraTruoc = "7 MP",
                CameraSau = "8 MP",
                Sim = "Không",
                Pin = " Luthium-Polymer",
                CPU = "	Apple A12 Bionic 6 nhân, 2 nhân 2.5 GHz & 4 nhân 1.6 GHz",
                GPU = "Apple GPU 4 nhân",
                RAM = "3 GB",
                ROM = "64 GB",
                TrongLuong = "300 g",

            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 20,
                ManHinh = "15.6' IPS ( 1920 x 1080 ) , không cảm ứng",
                HeDieuHanh = "Windows 10 Home SL 64-bit",
                CameraTruoc = "Có",
                CameraSau = "Không",
                Sim = "Không",
                Pin = " 4 cell 56 Wh Pin liền",
                CPU = "	 Intel Core i7-8750H ( 2.2 GHz - 4.1 GHz / 9MB / 6 nhân, 12 luồng )",
                GPU = "Intel UHD Graphics 630 / NVIDIA GeForce GTX 1050Ti 4GB GDDR5",
                RAM = "1 x 8GB DDR4 2666MHz",
                ROM = "128GB SSD M.2 SATA / 1TB HDD 5400RPM",
                TrongLuong = "2.7 kg",

            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 21,
                ManHinh = " 15.6' SVA(1920 x 1080)",
                HeDieuHanh = "Windows 10 Home SL 64-bit",
                CameraTruoc = "Có",
                CameraSau = "Không",
                Sim = "Không",
                Pin = " 3 cell 51 Wh",
                CPU = "	  Intel Core i5 9300H",
                GPU = " NVIDIA GeForce GTX 1050 3GB GDDR5 / Intel UHD Graphics 630",
                RAM = "2 x 4GB DDR4 2666MHz",
                ROM = "256GB SSD M.2 NVMe",
                TrongLuong = "2.3 kg",

            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 22,
                ManHinh = " 10 inch PixelSense 10-Point Touch Display",
                HeDieuHanh = "Windows 10 S",
                CameraTruoc = " 5MP",
                CameraSau = "8MP",
                Sim = "Không",
                Pin = " 3 cell 51 Wh",
                CPU = "1.6 GHz Intel Pentium 4415Y Dual-Core",
                GPU = "Card đồ họa Intel HD Graphics 615",
                RAM = "4GB, SSD 64GB",
                ROM = "",
                TrongLuong = "0.6 kg",

            });
            context_.CauHinhSanPhamContext.AddOrUpdate(new CauHinhSanPham()
            {
                SanPhamId = 23,
                ManHinh = " 10 inch PixelSense 10-Point Touch Display",
                HeDieuHanh = " Win 10 Pro Bản quyền",
                CameraTruoc = "8MP flash LED,3,5MP",
                CameraSau = "",
                Sim = "Không",
                Pin = "",
                CPU = "Intel Atom X7",
                GPU = "1920 x 1280 pixels",
                RAM = "4GB",
                ROM = "128GB SSD",
                TrongLuong = "0.62 kg",
            });
                context_.SaveChanges();
            
        }
    }
}