using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCalc
{
    public class QuadraticEquation
    {
        public QuadraticEquation(double aegyutthato, double begyutthato, double cegyutthato)
        {
            A = aegyutthato;
            B = begyutthato;
            C = cegyutthato;
        }
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
    }
    public class QuadraticResult
    {
        public string FirstValue { get; set; }
        public string SecondValue { get; set; }
    }

}

