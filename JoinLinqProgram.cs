using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinLinqProgram
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int StandardID { get; set; }
    }

    public class Standard
    {
        public int StandardID { get; set; }
        public string StandardNmae { get; set; }
        
    }
    public class Program
    {
        static void Main(string[] args)
        {

            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "Shalini", Age = 18, StandardID = 1, Address = "Patna", Email = "shalinikr97950@gmail.com" } ,
                new Student() { StudentID = 2, StudentName = "Puja",  Age = 21, StandardID = 2, Address = "Delhi", Email = "pujakumari98076@gmail.com" } ,
                new Student() { StudentID = 3, StudentName = "Bulbul",  Age = 18, StandardID = 3 , Address = "Kolkata", Email = "bulbulkr96750@gmail.com"} ,
                new Student() { StudentID = 4, StudentName = "Rani" , Age = 20, StandardID = 4 , Address = "Nepal", Email = "Ranikum98765@gmail.com"} ,
                new Student() { StudentID = 5, StudentName = "Ritika" , Age = 21, StandardID = 5, Address= "Hyderabad", Email = "ritikakr87905@gmail.com" }
            };

            IList<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardNmae="Standard 102"},
                new Standard(){ StandardID = 2, StandardNmae="Standard 103"},
                new Standard(){ StandardID = 3, StandardNmae="Standard 104"},

                new Standard(){ StandardID = 4, StandardNmae="Standard 105"},
                new Standard(){ StandardID = 5, StandardNmae="Standard 106"},
                new Standard(){ StandardID = 6, StandardNmae="Standard 107"},
                new Standard(){ StandardID = 7, StandardNmae="Standard 108"}
            };


            var innerJoinResult = studentList.Join(// outer sequence 
                      standardList,  // inner sequence 
                      student => student.StandardID,    // outerKeySelector
                      standard => standard.StandardID,
                      (student, standard) => new  // result selector
                      {
                          StudentName = student.StudentName,
                          StandardName = standard.StandardNmae,
                          Address = student.Address,
                          Email = student.Email 
                      });


            foreach (var obj in innerJoinResult)
            {
                Console.WriteLine("{0} - {1} - {2} - {3} ", obj.StudentName, obj.StandardName, obj.Address, obj.Email);
                Console.ReadKey();  
            }

            
        }
    }
}
