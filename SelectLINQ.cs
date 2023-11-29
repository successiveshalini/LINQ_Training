using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectLinqProgram
{
    public class Student
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
        public string Address { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", StudentAge = 21, Address = "Delhi" } ,
            new Student() { StudentID = 2, StudentName = "Moin",  StudentAge = 22, Address = "Kolkata" } ,
            new Student() { StudentID = 3, StudentName = "Bill",  StudentAge = 23 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , StudentAge = 24 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , StudentAge = 25 }
        };

            // returns collection of anonymous objects with Name and Age property
            var selectResult = studentList.Select(s => new {
               // Name = s.StudentName,
                StudentAge = s.StudentAge,   
            });

            // iterate selectResult
            foreach (var item in selectResult)
            Console.WriteLine(" StudentAge: {0}", item.StudentAge);
            Console.ReadKey();  


            //    IList<Student> studentList = new List<Student>() {
            //    new Student() { StudentID = 1, StudentName = "Shalini", Age = 13 } ,
            //    new Student() { StudentID = 2, StudentName = "Rohit", Age = 21 } ,
            //    new Student() { StudentID = 3, StudentName = "Shoan",  Age = 18 } ,
            //    new Student() { StudentID = 4, StudentName = "Puja" , Age = 20 } ,
            //    new Student() { StudentID = 5, StudentName = "Soni" , Age = 15 }
            //};

            //    // returns collection of anonymous objects with Name and Age property
            //    var selectResult = from s in studentList
            //                       select new { studentNmae = "Mr. " + s.StudentName, Age = s.Age };

            //    // iterate selectResult
            //    foreach (var item in selectResult)
            //    Console.WriteLine("Student Name: {0}, Age: {1}", item.studentNmae, item.Age);
            //    Console.ReadKey();  

        }
    }
}
