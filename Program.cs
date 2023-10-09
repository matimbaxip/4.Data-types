using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaration
            string name = "Matimba";
            int age = 35;
            bool isTall = false;
            Double weight = 80.2;

            /* For the smallest least precisedecimal use float'
            * for more precise use decimal e.g Money'
            * In most cases double will do just fine
            * */

            Console.WriteLine(name + "Is" +  age + "he weighs" + weight);
            Console.WriteLine("It is" + isTall + "that he is tall");

            // Freeze console
            Console.ReadLine();

        }
    }
}
