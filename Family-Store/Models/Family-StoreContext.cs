using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family_Store.Models
{
    
    
        public class family_storeContext : DbContext
        {


            public family_storeContext(DbContextOptions<family_storeContext> options)
                : base(options)
            { }

            public DbSet<Bags> bag { get; set; }

            public DbSet<Boots> boot { get; set; }

            public DbSet<Clothes> clothes { get; set; }

            public DbSet<Dresses> dress { get; set; }

            public DbSet<family> Family { get; set; }

            public DbSet<Jakets> jaket { get; set; }

            public DbSet<Sandals> sandal { get; set; }

            public DbSet<Scarves> scarf { get; set; }

            public DbSet<Shoes> shoes { get; set; }

            public DbSet<Shorts> shorts { get; set; }


            public DbSet<Skirts> skirts { get; set; }


            public DbSet<Trousers> trousers { get; set; }


            public DbSet<T_shirts> t_shirts { get; set; }

        public DbSet<Logincs>log { get; set; }


        
    

}
}
