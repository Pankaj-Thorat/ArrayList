using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            //create
            numbers.Add(11);
            numbers.Add(22);
            numbers.Add(33);

            //read
            foreach (int i in numbers) { Console.WriteLine(i); }

            //update
            numbers[2] = 44;
            Console.WriteLine("modified element: " + numbers[2]);

            //delete
            numbers.Remove(22);
            Console.WriteLine("After removing");
            foreach (int i in numbers) { Console.WriteLine(i); }

           
        }
    }
}
