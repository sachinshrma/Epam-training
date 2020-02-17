using StudentRegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentRegistrationForm.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student/Details
        public ActionResult Find()
        {
            return View();
        }

        [HttpPost]
        // Post: student/Details
        public ActionResult Details(FormCollection collection)
        {
            if (int.TryParse(collection.Get("id"), out int rollNo))
            {
                Student student = StudentDAO.GetInstance().findStudentByRollNo(rollNo);
                return View(student);
            }
            return View("Find");
        }
        // GET: Student/List
        public ActionResult List()
        {
            List<Student> studentList = StudentDAO.GetInstance().GetAllStudents();
            return View(studentList);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student student)
        {
            try
            {
                StudentDAO objDAO = StudentDAO.GetInstance();
                if (objDAO.AddStudent(student))
                   TempData["message"]="Created Successfully!!";
                else
                   TempData["message"]="Error occured!!";


                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }
    }
}
