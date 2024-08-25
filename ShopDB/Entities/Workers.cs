using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDB.Entities
{
    public class Workers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public string Email {  get; set; }
        public string PhoneNumber { get; set; }
        public int PositionId {  get; set; }
        public int ShopId {  get; set; }
        public Positions Position { get; set; }
        public Shops Shop { get; set; }
    }
}
