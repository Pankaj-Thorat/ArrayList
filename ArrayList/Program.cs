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

            //Dictionary
            Dictionary<string, int> mydict = new Dictionary<string, int>();
            mydict = DictionaryClass.AddElements(mydict);

            DictionaryClass.AddElements(mydict);

            foreach (KeyValuePair<string, int> dict in mydict)
            {
                Console.WriteLine("name: " + dict.Key + "\tMarks : " + dict.Value);
            }

            //update
            mydict["Pankaj"] = 99;
            Console.WriteLine("After Update--");

            foreach (KeyValuePair<string, int> dict in mydict)
            {
                Console.WriteLine("name: " + dict.Key + "\tMarks : " + dict.Value);
            }
            //delete
            mydict.Remove("Kiran");

            Console.WriteLine("After Delete--");

            foreach (KeyValuePair<string, int> dict in mydict)
            {
                Console.WriteLine("name: " + dict.Key + "\tMarks : " + dict.Value);
            }
        }
    }
}
