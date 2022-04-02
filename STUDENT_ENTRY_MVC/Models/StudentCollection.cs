namespace STUDENT_ENTRY_MVC.Models
{
    static public class StudentCollection
    {

        public static List<Student> Students = new List<Student>();
        public static int Id = 4;

        static StudentCollection()
        {
            Students.Add(new Student { ID = 1, Name = "Asim", Degree = "Bsse", CGPA = 3.5f, Semester = 6 });
            Students.Add(new Student { ID = 2, Name = "Hassan", Degree = "Bsse", CGPA = 3.5f, Semester = 6 });
            Students.Add(new Student { ID = 3, Name = "Faizan", Degree = "Bsse", CGPA = 3.5f, Semester = 6 });
            Students.Add(new Student { ID = 4, Name = "Jawad", Degree = "Bsse", CGPA = 3.5f, Semester = 6 });
        }

        public static void AddStudent(Student s) 
        { 
            int id = Id + 1;
            s.ID = id;  
            Students.Add(s);
        
        }

    }

}
