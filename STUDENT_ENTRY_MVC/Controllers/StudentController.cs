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
                ModelState.AddModelError(String.Empty, "Please fullfill the required requirements mentioned below !");
                return View();
            }
            
        }

        public ViewResult ShowAllStudents()
        {
            return View(StudentCollection.Students);
        }

        public ViewResult Details (int id) 
        {
            Student s = StudentCollection.Students.Find(s => s.ID == id);
            return View("StudentView", s);
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            Student s = StudentCollection.Students.Find(s => s.ID == id);
            return View("EditForm", s);
        }

        [HttpPost]
        public ViewResult Edit(int id,Student s)
        {
            if (ModelState.IsValid)
            {
                foreach (Student st in StudentCollection.Students)
                {
                    if (st.ID == s.ID)
                    {
                        st.Name = s.Name;
                        st.Degree = s.Degree;
                        st.CGPA = s.CGPA;
                        st.Semester = s.Semester;
                        break;
                    }
                }
                return View("ShowAllStudents", StudentCollection.Students);

            }
            else
            {
                ModelState.AddModelError(String.Empty, "Please fullfill the required requirements mentioned below !");
                return View("EditForm");
            }
          
        }

        public ViewResult Delete(int id)
        {
            Student s = StudentCollection.Students.Find(s => s.ID == id);
            StudentCollection.Students.Remove(s);
            return View("ShowAllStudents",StudentCollection.Students);
        }
    }
}
