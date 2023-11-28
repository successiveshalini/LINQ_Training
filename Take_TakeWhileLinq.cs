using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_TakeWhileLinq
{
    public class Program
    {

        static void Main(string[] args)
        {
            IList<int> intList = new List<int>() { 10, 20, 30, 40, 50, 60, };

            var newList = intList.Take(2);

            foreach (var str in newList)
                Console.WriteLine(str);

            IList<string> strList = new List<string>() { "Puja", "Shalini", "Shyam", "Mohan", "Guriya" };

            var onlyList = strList.Take(1);

            foreach (var str in newList)
                Console.WriteLine(str);
            IList<string> strList1 = new List<string>() { "Apple", "Mango", "Graps", "Lichi" };


            var resultList = strList.TakeWhile((s, i) => s.Length > i);

            foreach (string str in resultList)
                Console.WriteLine(str);

            IList<string> strList2 = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven" };

            var onlyList1 = strList.TakeWhile(s => s.Length > 4);

            foreach (var str in onlyList)
            Console.WriteLine(onlyList);
            Console.ReadKey();  
        }
    }
}
