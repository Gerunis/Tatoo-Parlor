using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatooParlor
{
    
    /// <summary>
    /// запись в салон
    /// </summary>
    public class Registration
    {
        /// <summary>
        /// контактные данные клиента (имя, возраст, контакты, пол)
        /// </summary>
        public string VisitorName { get; set; }

        public int Age { get; set; }

        public string Contacts { get; set; }

        public Gender Gender { get; set; }

        /// <summary>
        /// пример тату
        /// </summary>
        public Tatoo Tatoo { get; set; }

        /// <summary>
        /// часть тела
        /// </summary>
        public BodyPart BodyPart { get; set; }

        /// <summary>
        /// к какому мастеру
        /// </summary>
        public Master Master { get; set; }

    }


    /// <summary>
    /// пол посетителя
    /// </summary>
    public enum Gender
    {
        Male,
        Female
    }
}
