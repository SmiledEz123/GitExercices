using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Fahrenheit
    {
        private double _temperature;
        public double Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }
        public static implicit operator Celsius(Fahrenheit farh)
        {
            return new Celsius() {  Temperature = (farh.Temperature -32) / 1.8};
        }
    }
}
