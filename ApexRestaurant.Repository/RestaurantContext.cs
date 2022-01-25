using Microsoft.EntityFrameworkCore;
using ApexRestaurant.Repository.Domain;
namespace ApexRestaurant.Repository
{
 public class RestaurantContext : DbContext
 {
 
 public RestaurantContext(DbContextOptions<RestaurantContext> options) : 
base(options)
 {
 }
 public DbSet<Customer> Customers { get; set; }
 
 public DbSet<Meal> Meals { get; set; }
 public DbSet<Menu_Item> Menu_Items { get; set; }
 public DbSet<Menu> Menu { get; set; }
 public DbSet<Ref_Staff_Role> Ref_Staff_Roles { get; set; }
 public DbSet<Staff> Staffs { get; set; }
 public DbSet<Meal_Dishes> Dishes{ get; set; }

 
 protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
     
     modelBuilder.Entity<Menu_Item>().HasNoKey();
     modelBuilder.Entity<Ref_Staff_Role>().HasNoKey();
     modelBuilder.Entity<Staff>().HasNoKey();
     modelBuilder.Entity<Meal_Dishes>().HasNoKey();

     
    base.OnModelCreating(modelBuilder);
 }
 
 }
}