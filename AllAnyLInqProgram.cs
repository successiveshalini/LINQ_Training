using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAnyLinqProgram
{
    public class Student
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 20 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 22 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 23 }
        };

            // checks whether all the students are teenagers    
            bool areAllStudentsTeenAger = studentList.Any(s => s.Age > 13 && s.Age < 21);


            Console.WriteLine(areAllStudentsTeenAger);
            Console.ReadKey();
        }
    }
}
