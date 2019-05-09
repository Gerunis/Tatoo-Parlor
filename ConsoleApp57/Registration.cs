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

        public string Age { get; set; }

        public string Contacts { get; set; }

        public string Gender { get; set; }

        public DateTime DateToVisit { get; set; }

        public string TatooStyles { get; set; }

        public string BodyPart { get; set; }

        public byte[] Drawing { get; set; }

        /// <summary>
        /// пример тату
        /// </summary>
        //public Tatoo Tatoo { get; set; }

        /// <summary>
        /// часть тела
        /// </summary>


        /// <summary>
        /// к какому мастеру
        /// </summary>
        public string Master { get; set; }

        public override string ToString()
        {
            return $"Имя: {VisitorName}, \t Возраст: {Age}, \t Телефон: {Contacts}, \t Часть тела: {BodyPart},\t" +
                $"Cтиль тату: {TatooStyles}, \t Мастер: {Master}, \t Дата: {DateToVisit}";
        }

    }


    /// <summary>
    /// пол посетителя
    /// </summary>
    //public enum Gender
    //{
    //    Male,
    //    Female
    //}

    
}
