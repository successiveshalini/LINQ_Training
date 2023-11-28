using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_LastOrDefault
{
    public class Program
    {
        static void Main(string[] args)
        {
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Shalini", "Soni", "Priti", "GunGun" };
            IList<string> emptyList = new List<string>();
            Console.WriteLine("The Element in intList : {0}", intList.Last());
            Console.WriteLine("The Element in strList : {0}", strList.Last());
            //Console.WriteLine("the Element in emptyList : {0}", emptyList.Last());    

            Console.WriteLine("Last Element in intList: {0}", intList.LastOrDefault());

            Console.WriteLine("Last Even Element in intList: {0}",
                              intList.LastOrDefault(i => i % 2 == 0));

            Console.WriteLine("Last Element in strList: {0}", strList.LastOrDefault());

            Console.WriteLine("Last Element in emptyList: {0}", emptyList.LastOrDefault());

            Console.ReadKey();  


        }
    }
}
