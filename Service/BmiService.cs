using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service
{
    public class BmiService
    {
        public double CalculateBmi(Person person)
        {
            var bmi = person.Weight / Math.Pow(person.Height, 2);
            return bmi;
        }
    }
}
