using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByLinq
{
    public class Student
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            //IList<Student> studentList = new List<Student>() {
            //    new Student() { StudentID = 1, StudentName = "Soni", Age = 18, Salary = 12900 } ,
            //    new Student() { StudentID = 2, StudentName = "Pinki",  Age = 15, Salary = 23000} ,
            //    new Student() { StudentID = 3, StudentName = "Rupa",  Age = 25, Salary = 24000} ,
            //    new Student() { StudentID = 4, StudentName = "Mohan" , Age = 20, Salary = 22000} ,
            //    new Student() { StudentID = 5, StudentName = "Shoan" , Age = 19, Salary = 340000 }
            //};

            //var orderByResult = from s in studentList
            //                    orderby s.Salary //Sorts the studentList collection in ascending order
            //                    select s;

            //var orderByDescendingResult = from s in studentList //Sorts the studentList collection in descending order
            //                              orderby s.Salary descending
            //                              select s;

            //Console.WriteLine("Ascending Order:");

            //foreach (var std in orderByResult)
            //    Console.WriteLine(std.Salary);

            //Console.WriteLine("Descending Order:");

            //foreach (var std in orderByDescendingResult)
            //    Console.WriteLine(std.Salary);
            //Console.ReadKey();



            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "Soni", Age = 18, Salary = 12900 } ,
                new Student() { StudentID = 2, StudentName = "Pinki",  Age = 15, Salary = 23000} ,
                new Student() { StudentID = 3, StudentName = "Rupa",  Age = 25, Salary = 24000} ,
                new Student() { StudentID = 4, StudentName = "Mohan" , Age = 20, Salary = 22000} ,
                new Student() { StudentID = 5, StudentName = "Shoan" , Age = 19, Salary = 340000 }
            };

            var orderByResult = from s in studentList
                                orderby s.Salary //Sorts the studentList collection in ascending order
                                select s;

            var orderByDescendingResult = from s in studentList //Sorts the studentList collection in descending order
                                          orderby s.StudentName descending
                                          select s;

            Console.WriteLine("Ascending Order:");

            foreach (var std in orderByResult)
                Console.WriteLine(std.StudentName);

            Console.WriteLine("Descending Order:");

            foreach (var std in orderByDescendingResult)
                Console.WriteLine(std.StudentName);
            Console.ReadKey();



        }
    }
}
