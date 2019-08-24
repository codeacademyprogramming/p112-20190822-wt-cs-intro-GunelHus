using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aralarinda boshluq simvolu olmaqla ededler daxil edin");
            List<int> listChange = new List<int>();
            string[] numbers =  Console.ReadLine().Split(' ');
            foreach (var change in numbers) {
                int intChange = int.Parse(change);
                listChange.Add(intChange);
            }
            Console.WriteLine(listChange.Max());
            Console.WriteLine(listChange.Sum());
        }  
    }
}
