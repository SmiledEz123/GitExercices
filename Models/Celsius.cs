using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Celsius
    {
       private double _temperature;
       public double Temperature { 
            get { return _temperature; } 
            set { _temperature = value; } 
        }
        public static explicit operator Fahrenheit(Celsius cel)
        {
            return new Fahrenheit() { Temperature = (cel.Temperature *1.8) +32 };
        }
    }
}
