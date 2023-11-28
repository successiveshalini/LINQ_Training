using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skip_SkipWhileLinq
{
    public class Program
    {

        static void Main(string[] args)
        {
            //IList<string> strList = new List<string>() {
            //                                "Shalini",
            //                                "Soni",
            //                                "Subham",
            //                                "suriti",
            //                                "Sudha",
            //                                "Sanju"  };

            //var result = strList.SkipWhile(s => s.Length > 4);

            //foreach (string str in result)
            //    Console.WriteLine(str);
            //Console.ReadKey();
            IList<string> strList = new List<string>() { "Shalini", "Shoan", "Priya", "Punnam", "Ashish" };

            var result = strList.Skip(3);

            foreach (var str in result)
            Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}
