using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMethodProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            // string collection
            IList<string> stringList = new List<string>() {
            "C# Tutorials",
            "VB.NET Tutorials",
            "Learn C++ Tutorials",
            "MVC Tutorials" ,
            "Java"
        };

            // LINQ Method Syntax
            var result = stringList.Where(s => s.Contains("Tutorials"));


            foreach (var str in result)
            {
                Console.WriteLine(str);
                Console.ReadKey();  

            }
        }
    }
}
