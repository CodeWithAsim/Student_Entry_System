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
            StudentCollection.AddStudent(s);
            return View("StudentView",s);
        }
        public ViewResult ShowAllStudents()
        {
            return View(StudentCollection.Students);
        }

    }
}
