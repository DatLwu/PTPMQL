using DemoMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoMvc.Data{
    public class ApplicationDbcontext : DbContext{
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> option) : base(option){}
        public DbSet<Person> Person {get; set;}
        public DbSet<Employee> Employee {get; set;}

              
    }
}