using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartQuiz
{
    class Item
    {
        private string _country;
        private string _timeOfDay;
        private string _animal;
        private int _attacks;

        public Item(string country, string timeOfDay, string animal, int attacks)
        {
            Country = country;
            TimeOfDay = TimeOfDay;
            Animal = animal;
            Attacks = attacks;
        }

        public string Country { get; set; }

        public string TimeOfDay { get; set; }

        public string Animal { get; set; }

        public int Attacks { get; set; }


    }
}
