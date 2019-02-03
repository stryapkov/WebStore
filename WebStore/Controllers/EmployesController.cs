using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class EmployesController : Controller
    {

        private readonly List<EmployeeView> _employees = new List<EmployeeView>
        {
            new EmployeeView
            {
                Id = 1,
                FirstName = "Иван",
                SurName = "Иванов",
                Patronymic = "Иванович",
                Age = 25,
                Department="Отдел ИТ"
            },
            new EmployeeView
            {
                Id = 2,
                FirstName = "Петр",
                SurName = "Петров",
                Patronymic = "Петрович",
                Age = 30,
                Department="Отдел закупок"
            },
             new EmployeeView
            {
                Id = 3,
                FirstName = "Берк",
                SurName = "Анатолий",
                Patronymic = "Иванович",
                Age = 35,
                Department="Руководство"
            }
        };


        public IActionResult Index()
        {
            return View(_employees);
        }
    }
}