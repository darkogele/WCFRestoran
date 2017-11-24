using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFSOAPService.Model;
using WCFSOAPService.DAL;
namespace WCFSOAPService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        EmployeeDbContext db = new EmployeeDbContext();

        public void Add(Model.Employee e)
        {
            db.Empoloyees.Add(e);
            db.SaveChanges();
        }

        public void Edit(Employee e)
        {
            db.Entry(e).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public Employee Get(int id)
        {
            return db.Empoloyees.Find();
        }

        public List<Employee> getAllEmployees()
        {
            return db.Empoloyees.ToList();
        }

        public void Remove(int Id)
        {
            Employee e = db.Empoloyees.Find(Id);
            if (e !=null)
            {
                db.Empoloyees.Remove(e);
                db.SaveChanges();
            }
           
        }
        public string Salary(int id)
        {
            var Employee = db.Empoloyees.FirstOrDefault(x => x.Id == id);
            return Employee.Salary.ToString();
        }
    } 
}
