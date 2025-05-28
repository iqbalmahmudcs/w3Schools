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
        private string _model;
        private string _color;
        private int _year;


        //Default Constructor
        public Car() { }

        //Constructor
        public Car(string model, string color, int year)
        {
            _model = model;
            _color = color;
            _year = year;

        }


        //Methods
        public void Display()
        {
            Console.WriteLine($"Model: {_model}");
            Console.WriteLine($"Color: {_color}");
            Console.WriteLine($"Year: {_year}");
            Console.WriteLine();
        }

    }
}
