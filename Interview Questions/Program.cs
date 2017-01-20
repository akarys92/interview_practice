using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interview_Questions.Chapter_1;
using Interview_Questions.Chapter_2;
using Interview_Questions.Chapter_3;
using Interview_Questions.Helpers;


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
                    case "test":
                        Binary_Search_Tree tree = new Binary_Search_Tree();
                        string input = Console.ReadLine();
                        while (input != "back")
                        {
                            if (input == "search") {
                                input = Console.ReadLine();
                                int int_i = Convert.ToInt32(input);
                                Console.WriteLine(tree.search(int_i));
                            }
                            else
                            {
                                int input_i = Convert.ToInt32(input);
                                tree.insert(input_i);
                            }
                            input = Console.ReadLine();
                        }
                        

                        break;
                }
            }
        }
    }
}
