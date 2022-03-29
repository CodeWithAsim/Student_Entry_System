using Microsoft.AspNetCore.Mvc;
using STUDENT_ENTRY_MVC.Models;

namespace STUDENT_ENTRY_MVC.Controllers
{
    public class StudentController : Controller
    {

        [HttpGet]
        public ViewResult StudentForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult StudentForm(Student s)
        {
            if (ModelState.IsValid)
            {
                StudentCollection.AddStudent(s);
                return View("StudentView", s);
            }
            else 
            {
                ModelState.AddModelError(String.Empty, "Please fullfill the requirements !");
                return View();
            }
            
        }
        public ViewResult ShowAllStudents()
        {
            return View(StudentCollection.Students);
        }

    }
}
