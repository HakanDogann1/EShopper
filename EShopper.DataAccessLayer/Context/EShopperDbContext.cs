using EShopper.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.DataAccessLayer.Context
{
    public class EShopperDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public EShopperDbContext()
        {
            
        }
        public EShopperDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
 
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactLocation> ContactLocations { get; set; }
        public DbSet<CouponCode> CouponCodes { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<PaymentRegister> PaymentRegisters { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ColorRegister> ColorRegisters { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<SizeRegister> SizeRegisters { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }


        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Header>().Property(x => x.Name).IsRequired();
        //}

    }
}
