using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name;
            
            System.Console.WriteLine("Enter your Name: ");
            name = Convert.ToString(Console.ReadLine());
            System.Console.WriteLine("Enter your Age: ");
            age = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("Hello, World " + name + ".");
            System.Console.WriteLine("You are " + age + " years old.");
            Console.Read();
        
        }
    }
}
