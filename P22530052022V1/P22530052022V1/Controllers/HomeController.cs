using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P22530052022V1.DAL;
using P22530052022V1.Models;
using P22530052022V1.ViewModels.HomeViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P22530052022V1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //return View(_context.Students.Include(s=>s.Group).ToList());

            //List<Group> groups = _context.Groups.ToList();
            //List<Student> students = new List<Student>();

            //foreach (Group group in groups)
            //{
            //    List<Student> students1 = _context.Students.Where(s => s.GroupId == group.Id).ToList();
            //    students.AddRange(students1);
            //}

            //HomeViewModel homeViewModel = new HomeViewModel
            //{
            //    Groups = groups,
            //    Students = students
            //};

            //return View(homeViewModel);

            return View(_context.Groups.Include(g => g.Students).ToList());
        }

        public IActionResult About(int? id)
        {
            ViewBag.Id = id;

            return View();
        }
    }
}
