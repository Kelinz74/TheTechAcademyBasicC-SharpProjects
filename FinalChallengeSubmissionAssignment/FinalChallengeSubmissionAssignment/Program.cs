using System;
using System.Data.Entity;

namespace FinalChallengeSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {            
            using (var db = new StudentContext())
            {
                
                Console.WriteLine("What is your name?");
                var studentName = Console.ReadLine();                

                var nStudent = new Student { studentName = studentName };                

                db.Students.Add(nStudent);                
                db.SaveChanges();                
            }
           
        }
    }
    public class Student
    {        
        public int StudentId { get; set; }
        public string studentName { get; set; }
        

        public virtual Lazy<Student> Students { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
