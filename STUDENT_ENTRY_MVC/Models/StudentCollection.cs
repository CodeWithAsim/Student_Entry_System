namespace STUDENT_ENTRY_MVC.Models
{
    public class StudentCollection
    {
        public static List<Student> Students = new List<Student>();

        public static void AddStudent(Student s) 
        { 
            
            Students.Add(s);
        
        }
    }
}
