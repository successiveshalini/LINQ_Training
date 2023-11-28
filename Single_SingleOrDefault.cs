using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_SingleOrDefault1
{
    public class Program
    {
        static void Main(string[] args)
        {
            IList<int> oneElementList = new List<int>() { 6 };
            IList<int> intList = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IList<string> strList = new List<string>() { "Shalini" };
            IList<string> emptyList = new List<string>();

            Console.WriteLine("The only element in oneElementList: {0}", oneElementList.Single());
            Console.WriteLine("The only element in oneElementList: {0}", oneElementList.SingleOrDefault());
            Console.WriteLine("Element in emptyList: {0}", emptyList.SingleOrDefault());
            Console.WriteLine("The only element in strList: {0}", strList.SingleOrDefault());

            //Console.WriteLine("The only element which is less than 10 in intList: {0}",
            //             intList.Single(i => i < 10));

            Console.ReadKey();



            //// IList<int> singleElement = new List<int>() { 8 };
            //IList<int> intlist = new List<int>() {10, 20, 30, 40, 50, 60, 70, };
            //Console.WriteLine("The only element in intlist : {0}", intlist.SingleOrDefault());
            ////Console.WriteLine("the only  SingleElement : {0}", singleElement.Single());

        }
    }
}
