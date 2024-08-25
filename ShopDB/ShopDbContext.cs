using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDB
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);


            optionsBuilder.UseSqlServer(@"Data Source = localhost\SQLEXPRESS;
                                 Initial Catalog= MusicDb;
                                 Integrated Security=true;
                                 Connect Timeout = 2;Encrypt=False;
                                 Trust Server Certificate=False;
                                 Application Intent=ReadWrite;
                                 Multi Subnet Failover=False");
        }
    }
}
