using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Service;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bmiService = new BmiService();

            var person = new Person(21, "Alex", 100, 1.82);

            var bmi = bmiService.CalculateBmi(person);

            Console.WriteLine(bmi);
        }
    }
}
