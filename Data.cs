using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MathCalc
{
    [Serializable]
    public class Data
    {
        public int Id { get; set; }
        [XmlElement(ElementName ="a_együttható")]
        public string A { get; set; }
        [XmlElement(ElementName = "b_együttható")]
        public string  B { get; set; }
        [XmlElement(ElementName = "c_együttható")]
        public string  C { get; set; }

        public Data() : this(0, "", "", "", "")
        {

        }

        public Data(int id, string equation, string a, string b, string c)
        {
            Id = id;
            A = a;
            B = b;
            C = c;
        }
    }
}
