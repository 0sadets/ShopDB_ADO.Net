using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDB.Entities
{
    public class Cities
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int CountryId {  get; set; }
        public Countries Country { get; set; }
    }
}
