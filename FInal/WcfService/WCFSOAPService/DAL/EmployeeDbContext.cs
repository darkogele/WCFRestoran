using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WCFSOAPService.Model;

namespace WCFSOAPService.DAL
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext()
            :base("EmployeeDbContext")
        {

        }
        public DbSet<Employee>Empoloyees { get; set; }
    }
    public  class EmployeeDbInitializer : DropCreateDatabaseIfModelChanges<EmployeeDbContext>
    {
        protected override void Seed(EmployeeDbContext context)
        {
            context.Empoloyees.Add(new Employee() { Name = "Darko", Address = "Petar Deljan" });
            context.SaveChanges();
        }
    }
}