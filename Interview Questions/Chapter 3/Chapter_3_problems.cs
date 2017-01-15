using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Questions.Chapter_3
{
    class Chapter_3_problems
    {
        public Chapter_3_problems() {
            string problem = "";
            while (problem != "back")
            {
                Console.WriteLine("Chapter 3: Select a problem (2,3, 4, 5, 6) or 'back' to go back");
                problem = Console.ReadLine();
                switch (problem)
                {
                    case "1":
                        Console.WriteLine("Not implemented");
                        break;
                    case "2":
                        string input = "";
                        Console.WriteLine("Use 'push' to push and 'pop' to pop, 'min' to get min and 'print' to print.");
                        Number_3_2 stack = new Number_3_2();
                        while (input != "Exit")
                        {
                            stack.print_stack();
                            input = Console.ReadLine();
                            if (input == "push")
                            {
                                string pusher = Console.ReadLine();
                                stack.push(Convert.ToInt32(pusher));
                            }
                            if (input == "pop")
                            {
                                Console.WriteLine(stack.pop());
                            }
                            if (input == "min") {
                                Console.WriteLine(stack.get_min());
                            }
                        }
                        break;
                    case "3":
                        Number_3_3 q_3 = new Number_3_3();
                        break;
                    case "4":
                        Console.WriteLine("Number of objects to play Towers of Hanoi with?");
                        int num_objs = Convert.ToInt32(Console.ReadLine());
                        Number_3_4 q_4 = new Number_3_4(num_objs);
                        break;
                    case "5":
                        Number_3_5 q_5 = new Number_3_5();
                        break;
                    case "6":
                        Number_3_6 q_6 = new Number_3_6();
                        break;
                }
            }
        }
    }
}
