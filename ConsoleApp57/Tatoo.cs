using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatooParlor
{
    public class Tatoo
    {
        public static List<string> TatooStyles = new List<string>() { };

        public byte[] Drawing { get; set; }

        public bool Monochrome { get; set; }

        public string Style { get; set; }
    }

    public enum BodyPart
    {

    }
}
