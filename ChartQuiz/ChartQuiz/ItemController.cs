using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartQuiz
{
    class ItemController
    {
        private List<Item> _list;
        private string _groupingCol;
        private string _summarizeCol;
        private int _maxVal;
        public ItemController(List<Item> list, string groupingCol, string summarizeCol)
        {
            _list = list;
            GroupingCol = groupingCol;
            SummarizeCol = summarizeCol;
            GetMaxValue();
        }

        public string GroupingCol { get; set; }
        public string SummarizeCol { get; set; }
        public int MaxVal { get; set; }

        private void GetMaxValue()
        {
            MaxVal = 0;
            foreach (var item in _list)
            {
                if(item.Attacks > MaxVal)
                {
                    MaxVal = item.Attacks;
                }
            }
        }


        public void PrintList()
        {
            foreach (var item in _list)
            {
                switch (GroupingCol.ToLower())
                {
                    case "country":
                        Console.Write($"{item.Country,-50}");
                        PrintChart(item);
                        break;
                    case "timeofday":
                        Console.Write($"{item.TimeOfDay,-50}");
                        PrintChart(item);
                        break;
                    case "animal":
                        Console.Write($"{item.Animal,-50}");
                        PrintChart(item);
                        break;
                    case "attacks":
                        Console.Write($"{item.Attacks,-50}");
                        PrintChart(item);
                        break;
                }
            }
        }

        private void PrintChart(Item item)
        {
            if (SummarizeCol.ToLower() == "attacks")
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                for (var i = 0; i < CalculatePercentage(item.Attacks); i++)
                {
                    Console.Write(" ");
                }
                Console.ResetColor();
            }
        }

        private int CalculatePercentage(int value)
        {
            return (int)Math.Round((double)value / MaxVal * 100);
        }
    }
}
