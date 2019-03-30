using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatooParlor
{
    public class Registration
    {
        public string VisitorName { get; set; }
        public int Age { get; set; }
        public string Contacts { get; set; }

        public Gender Gender { get; set; }

        public Tatoo Tatoo { get; set; }
        public BodyPart BodyPart { get; set; }


        public Master Master { get; set; }

    }

    public enum Gender
    {
        Male,
        Female
    }
}
