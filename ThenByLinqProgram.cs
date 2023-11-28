using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThenByLinq
{
    public class Student
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "Mohan", Age = 18, Address = "Delhi" } ,
                new Student() { StudentID = 2, StudentName = "Shyam",  Age = 15, Address = "Kolkata"} ,
                new Student() { StudentID = 3, StudentName = "Rohan",  Age = 25, Address = "Patna"} ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, Address = "Pakistan"} ,
                new Student() { StudentID = 5, StudentName = "Sita" , Age = 19, Address = "Dubai" }
            };
            var thenByResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age).ThenBy(s => s.Address);

            var ThenByDescending = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age).ThenByDescending(s => s.Address);

            Console.WriteLine("ThenBy :");

            foreach (var std in thenByResult)
                Console.WriteLine("Name: {0}, Age:{1} Address:{2}", std.StudentName, std.Age, std.Address);

            Console.WriteLine("ThenByDescending:");

            foreach (var std in ThenByDescending)
                Console.WriteLine("Name: {0}, Age:{1} Address:{2}", std.StudentName, std.Age, std.Address);
            Console.ReadKey();


        }
    }
}
