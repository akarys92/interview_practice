using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interview_Questions.Chapter_1;
using Interview_Questions.Chapter_2;
using Interview_Questions.Chapter_3;


namespace Interview_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            string problem = "";
            while (problem != "exit")
            {
                Console.WriteLine("Select a Chapter (1, 2, 3) or 'exit' to leave: ");
                problem = Console.ReadLine();
                switch (problem) {
                    case "1":
                        Chapter_1_problems ch = new Chapter_1_problems();
                        break;
                    case "2":
                        Chapter_2_problems ch2 = new Chapter_2_problems();
                        break;
                    case "3":
                        Chapter_3_problems ch3 = new Chapter_3_problems();
                        break;
                }
            }
        }
    }
}
