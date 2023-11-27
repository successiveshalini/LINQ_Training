using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProgram2
{
    public class Program
    {


        static void Main(string[] args)
        {
            string[] students = { "sohan", "soni", "Priti", "puja", "Rupa" };  //Data Source

            var LinqQuery = from student in students
                            where student.Contains('i') // Linq Query
                            select student;

            foreach (var student in LinqQuery)     // Query Execuation
                Console.WriteLine(student + " ");
            Console.ReadKey();  



        }
    }
}

