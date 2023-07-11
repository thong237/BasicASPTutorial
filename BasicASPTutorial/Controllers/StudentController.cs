using BasicASPTutorial.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace BasicASPTutorial.Controllers
{
    public class StudentController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Index()
        //{
        //    return Content("คะแนนสอบวิชาคอมพิวเตอร์");
        //}

        //public IActionResult ShowScore(int id) 
        //{ 
        //    return Content($"คะแนนสอบของนักเรียน เลขที่ {id}");
        //}

        public IActionResult Index()
        {
            Student s1 = new Student();          
            s1.Id = 1;
            s1.Name = "ทอง ทับทิม";
            s1.Score = 99;

            var s2 = new Student();
            s2.Id = 2;
            s2.Name = "โจโจ้";
            s2.Score = 45;

            Student s3 = new();
            s3.Id = 3;
            s3.Name = "ดีดี";
            s3.Score = 60;

            List<Student> Students = new List<Student>();
            Students.Add(s1);
            Students.Add(s2);
            Students.Add(s3);

            return View(Students);

        }

        // Defalt จะเป็น Get method
        public IActionResult Create()
        {
            return View();
        }

    }
}
