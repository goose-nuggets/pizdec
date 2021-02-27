using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
           double a1, b1, c1, d1;
           Console.WriteLine("Привет, уебище!");
           Console.WriteLine("Введи первое число, епта: ");
           string a = Console.ReadLine();
           bool true1 = double.TryParse(a, out a1);
           if (true1)
           {
           	Console.WriteLine("Ok");
           
            Console.WriteLine("Введи второе число, епта: ");
            string b = Console.ReadLine();
            bool true2 = double.TryParse(b, out b1);
            if (true2)
            {
        	 Console.WriteLine("Ok");
        	 
             double res = (a1 + b1) /2;
             Console.WriteLine(res);
             
            }
            else
            {
           	 Console.WriteLine("Иди в пизду");
            }
            
           }
           else
           {
           	Console.WriteLine("Иди нахуй");
           }
        }
    }
}