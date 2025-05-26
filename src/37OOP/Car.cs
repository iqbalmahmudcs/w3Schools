using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _37OOP
{
    public class Car
    {
        //Fields
        public string model;
        public string color;
        public int year;



        //Methods
        public void Display()
        {
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Year: {year}");
        }

    }
}
