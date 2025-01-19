using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.Write("Enter Your Name: ");
            //    string s = Console.ReadLine();
            //    Console.WriteLine("Name: "+s);


            //    Console.WriteLine("--------------------------");
            //    double d = 103.5456235464562546;
            //    string myname = "Hani";
            //    char c = 'H';
            //    bool b = true;
            //    int num = 42;
            //    const string myConst = "This is a constant";


            //    Console.WriteLine("Double: " +d);
            //    Console.WriteLine("String: "+myname);
            //    Console.WriteLine("Char: "+c);
            //    Console.WriteLine("Bool: "+b);
            //    Console.WriteLine("Int: "+num);
            //    Console.WriteLine("Const: "+myConst);

            //    Console.WriteLine("--------------------------");


            //    string[] cars = { "Toyota", "Honda", "BMW", "Mercedes" };
            //    Console.WriteLine("Cars in the array:");
            //    foreach (string C in cars)
            //    {
            //        Console.WriteLine(C);
            //    }
            //    Console.WriteLine($"Total cars:"+cars.Length);


            //    Console.WriteLine("--------------------------");


            //    Console.Write("Enter your first name: ");
            //    string firstName = Console.ReadLine();
            //    Console.Write("Enter your last name: ");
            //    string lastName = Console.ReadLine();
            //    Console.Write("Enter your year of birth: ");
            //    int yearOfBirth = int.Parse(Console.ReadLine());

            //    Console.WriteLine(firstName+lastName+yearOfBirth);


            //    Console.WriteLine("--------------------------");

            int[] elements = { 1, 2, 3 };
            Console.WriteLine("Enter 10 elements:");

            for (int i = 0; i < elements.Length; i++)
            {

                elements[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array elements: ");
            Console.WriteLine("Array elements: ");
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write(elements[i] + " ");
            }


        }
    }
}
