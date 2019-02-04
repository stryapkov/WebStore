using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Shop() => View();
        public IActionResult ProductDetails() => View();
        public IActionResult Login() => View();
        public IActionResult ContactUs() => View();
        public IActionResult CheckOut() => View();
        public IActionResult Cart() => View();
        public IActionResult BlogSingle() => View();
        public IActionResult Blog() => View();
        public IActionResult ErrorPage404() => View();

        //public IActionResult Details(int? id)
        //{
        //    var employee = _employees.FirstOrDefault(e => e.Id == id);
        //    if (employee is null)
        //        return NotFound();
        //    return View(employee);
        //}


        //public IActionResult AddEmployee(string FName, string SName, string Patronymic, int age, string Depart)
        //{
        //    _employees.Add(new EmployeeView
        //    {
        //        Id = 3,
        //        FirstName = FName,
        //        SurName = SName,
        //        Patronymic = Patronymic,
        //        Age = age,
        //        Department = Depart
        //    });
        //    return View(_employees);
        //}

    }
}