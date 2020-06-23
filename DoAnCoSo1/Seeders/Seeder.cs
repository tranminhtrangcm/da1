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
        public DoAnCoSo1DBContext context_ { get; set; }
        public Seeder(DoAnCoSo1DBContext context)
        {
            context_ = context;
        }

        private int GetRandomNumber(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue);
        }
    }
}