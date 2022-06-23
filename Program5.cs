using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Kutuzov";
            string secondName = "Vladimir";
            Console.WriteLine("До : " + "name = " + name + " secondName = " + secondName);
           
            string swapp;
            swapp = name;
            name = secondName;
            secondName = swapp;

            Console.WriteLine("После : " + "name = " + name + " secondName = " + secondName);            
        }
    }
}
