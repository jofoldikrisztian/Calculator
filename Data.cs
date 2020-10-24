using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCalc
{
    [Serializable]
    public class Data
    {
        public int Id { get; set; }
        public string Equation { get; set; }
        public string A { get; set; }
        public string  B { get; set; }
        public string  C { get; set; }

        public Data() : this(0, "", "", "", "")
        {

        }

        public Data(int id, string equation, string a, string b, string c)
        {
            Id = id;
            Equation = equation;
            A = a;
            B = b;
            C = c;
        }
    }
}
