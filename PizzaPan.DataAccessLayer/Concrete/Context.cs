using Microsoft.EntityFrameworkCore;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-LVPTDQG\SQLEXPRESS; initial catalog= CasgemDbPizzaPan; integrated security = true");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
