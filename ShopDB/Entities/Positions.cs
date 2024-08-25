using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDB.Entities
{
    public class Positions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Workers> Workers { get; set; }
    }
}
