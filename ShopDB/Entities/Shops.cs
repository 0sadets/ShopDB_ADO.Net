﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDB.Entities
{
    public class Shops
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CityId {  get; set; }
        public Cities City { get; set; }
        public int? ParkingArea {  get; set; }
        public ICollection<Products> Products { get; set; }
        public ICollection<Workers> Workers { get; set; }
    }
}
