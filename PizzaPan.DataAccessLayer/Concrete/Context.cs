using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using PizzaPan.EntityLayer.Concrete;
using System.Reflection.Emit;

namespace PizzaPan.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-LVPTDQG\SQLEXPRESS; initial catalog= CasgemDbPizzaPan; integrated security = true");
        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<CompanyInfo> CompanyInfos { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<OurTeam> OurTeams { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Block> Blocks { get; set; }

    }
}
