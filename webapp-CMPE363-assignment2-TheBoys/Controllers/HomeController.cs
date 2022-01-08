using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using webapp_CMPE363_assignment2_TheBoys.Models;
using webapp_CMPE363_assignment2_TheBoys.Data;

namespace webapp_CMPE363_assignment2_TheBoys.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _dbContext;

        public ActionResult Index()
        {
            ViewBag.empname = "";

            _dbContext = new AppDbContext("Server=tcp:azure-db-for-assignment2.database.windows.net,1433;Initial Catalog=AzureDB;Persist Security Info=False;User ID=ali;Password=A.d123456789;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            var viewmodel = new EmployeeViewModel();
            viewmodel.Employees = _dbContext.Employees.ToList();
            return View(viewmodel);
        }

        [HttpPost]
        public ActionResult Index(string empname, Employee emp)
        {
            ViewBag.empname = empname; 

            _dbContext = new AppDbContext("Server=tcp:azure-db-for-assignment2.database.windows.net,1433;Initial Catalog=AzureDB;Persist Security Info=False;User ID=ali;Password=A.d123456789;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            var employee = _dbContext.Employees.ToList().Where(e=>e.EmpName.Contains(empname));
            var viewmodel = new EmployeeViewModel();
            viewmodel.Employees = employee.ToList();
            return View(viewmodel);
        }


        public ActionResult Delete(Guid? id)
        {
             _dbContext = new AppDbContext("Server=tcp:azure-db-for-assignment2.database.windows.net,1433;Initial Catalog=AzureDB;Persist Security Info=False;User ID=ali;Password=A.d123456789;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            var itemToRemove = _dbContext.Employees.Find(id);

            if (itemToRemove != null)
            {
                _dbContext.Employees.Remove(itemToRemove);
                _dbContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }

    
}