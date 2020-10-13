using System;
using System.Collections.Generic;

namespace ChartQuiz
{
    class Program
    {
        static void Main(string[] args) { 
        
            List<Item> listOfItems = new List<Item>();

            Console.ReadLine();
            string line = Console.ReadLine();
            string groupingCol = args[0];
            string summarizeCol = args[1];
            while (!String.IsNullOrEmpty(line))
            {
                listOfItems.Add(new Item (line.Split('\t')[0], line.Split('\t')[1], line.Split('\t')[2], Int32.Parse(
                    line.Split('\t')[3])));
                line = Console.ReadLine();
            }

            ItemController controller = new ItemController(listOfItems, groupingCol, summarizeCol);
            controller.PrintList();
        }

    }
}
