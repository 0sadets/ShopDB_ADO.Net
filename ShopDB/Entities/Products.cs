using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDB.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Discount {  get; set; }
        public int Quantity {  get; set; }
        public bool IsInStock {  get; set; }
        public int? CategoryId { get; set; }
        public Categories Category { get; set; }
        public ICollection<Shops> Shops { get; set; }
    }
}
