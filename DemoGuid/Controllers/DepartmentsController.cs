using DemoGuid.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.Arm;

namespace DemoGuid.Controllers
{
    public class DepartmentsController : Controller
    {
        static List<Department> departmentsFirstLoad = DataInitializer.SeedDepartment();
        public IActionResult Index()
        {
          var departments =  departmentsFirstLoad;
            return View(departments);
        }
        [HttpGet]
        public IActionResult Details(Guid id)
        {
            var departments = departmentsFirstLoad.Find(d => d.Id == id);
            return View(departments);
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var department = departmentsFirstLoad.Find(d => d.Id == id);

            return View(department);
        }
        [HttpPost]
        public IActionResult Edit(Department dep)
        {
            var department = departmentsFirstLoad.Find(d => d.Id == dep.Id);
            if(department == null) 
            {
              return NotFound();
            }
            department.Name = dep.Name;
            return RedirectToAction("Index");
        }
        [HttpGet]
        [ActionName("Verwijder")]
        public IActionResult Delete(Department department)
        {
            var found = departmentsFirstLoad.Find(d => d.Id == department.Id);
            if (found == null)
            {
                return NotFound();
            }
            departmentsFirstLoad.Remove(found);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create()
        {
          ViewBag.Id = Guid.NewGuid();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            departmentsFirstLoad.Add(department);
            return RedirectToAction("Index");
        }


    }
    
}
