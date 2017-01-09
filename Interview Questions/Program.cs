using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interview_Questions.Chapter_1;


namespace Interview_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            string problem = "";
            while (problem != "exit")
            {
                Console.WriteLine("Select a Chapter (1, ) or 'exit' to leave: ");
                problem = Console.ReadLine();
                switch (problem) {
                    case "1":
                        Chapter_1_problems ch = new Chapter_1_problems();
                        break;
                }
            }
        }
    }
}
