using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using STManagemenet.Models;
using STManagemenet.Services;

namespace STManagemenet.Controllers
{
    public class StudentsController : Controller
    {
        IStudentService studentService;

        public StudentsController(IStudentService studentService)
        {
            this.studentService = studentService;
        }


        public IActionResult Index()
        {
            var list = studentService.FindAll();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.list = studentService.FindAllFiliere();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            studentService.Save(student);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var student = studentService.GetStudent(id);
            return View(student);
        }

        [HttpGet]
        public IActionResult CreateFiliere()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateFiliere(Filiere filiere)
        {
            studentService.Save(filiere);
            return RedirectToAction("Index");
        }

        public IActionResult IndexFiliere()
        {
            var list = studentService.FindAllFiliere();
            return View(list);
        }

        public IActionResult Delete(int id)
        {
            studentService.DeleteStudent(id);
            return RedirectToAction("Index");
        }



    }

}
