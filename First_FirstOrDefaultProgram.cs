using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_FirstOrDefaultProgram
{
    public class Program
    { 
        static void Main(string[] args)
        {
            IList<int> intList = new List<int>() { 6, 7, 8, 9, 10, 11, 12, 13, };
            IList<string> strList = new List<string>() { "Rohit Sharma", "Virat Kohli", "Ms Dhoni", "Sachine Tendulkar", "Sim Bhullar" };
            IList<string> emptyList = new List<string>();

            Console.WriteLine("1st Element in intList: {0}", intList.FirstOrDefault());

            Console.WriteLine("1st Even Element in intList: {0}", intList.FirstOrDefault(i => i % 2 == 0));

            Console.WriteLine("1st Element in strList: {0}", strList.FirstOrDefault());

            Console.WriteLine("1st Element in emptyList: {0}", emptyList.FirstOrDefault());

            IList<int> int1List = new List<int>() { 25, 22, 23, 24, 25, 26, 27, 28 };
            IList<string> stringList = new List<string>() { "Puja", "Shalini", "Soni", "Guriya", "Kanchan" };
            IList<string> empty1List = new List<string>();
            Console.WriteLine("emptyList.First()throws an InvalidOperationException");
            Console.WriteLine("1st  Element in stringList: {0} ", stringList.First());  
            Console.WriteLine("1st Element in intList: {0} ", int1List.First());

            Console.ReadKey();  
           

        }
    }
}
