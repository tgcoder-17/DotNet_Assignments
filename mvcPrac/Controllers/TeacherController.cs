using mvcPrac;
using mvcPrac.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcPrac.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ApplicationDBContext _db;

        public TeacherController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Teacher> listofsubjects = _db.Teacher;
            return View(listofsubjects);
        }

        [HttpGet]
        public IActionResult Edit(int subjectid)
        {
            var subobj = _db.Teacher.Find(subjectid);
            return View(subobj);

        }

        [HttpPost]
        public IActionResult Edit(Teacher updatedvaluesobj)
        {
            _db.Teacher.Update(updatedvaluesobj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult New(Teacher newTeacher)
        {
            _db.Teacher.Add(newTeacher);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int Teacherid)
        {

            var studobj = _db.Teacher.Find(Teacherid);
            return View(studobj);
        }


        [HttpPost]
        public IActionResult DeletePost(int ID)
        {
            var studobj = _db.Teacher.Find(ID);

            if (ModelState.IsValid)
            {

                _db.Teacher.Remove(studobj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studobj);
        }

    }
}
