using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatooParlor
{
    public class Master
    {        
        public string Name { get; set; }
        public int Age { get; set; }
        public bool[] Photo { get; set; }
        public DateTime WorkExperience { get; set; }
        public string Discription { get; set; }

        public List<string> MasterStyles { get; set; }

        public List<Tatoo> Examples { get; set; }

        public Dictionary<DateTime, Registration> TimeTable { get; set; }

    }
}
