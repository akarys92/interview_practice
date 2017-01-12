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
                Console.WriteLine("Chapter 3: Select a problem (1...) or 'back' to go back");
                problem = Console.ReadLine();
                switch (problem)
                {
                    case "1":
                        string input = "";
                        Console.WriteLine("Use 'push' to push and 'pop' to pop.");
                        Stack stack = new Stack();
                        while (input != "Exit") {
                            stack.print_stack();
                            input = Console.ReadLine();
                            if (input == "push") {
                                string pusher = Console.ReadLine();
                                stack.push(Convert.ToInt32(pusher));
                            }
                            if (input == "pop") {
                                Console.WriteLine(stack.pop());
                            }
                            
                        }
                        break;
                    case "2":
                        string input2 = "";
                        Stack_of_Stacks stack_O = new Stack_of_Stacks();
                        while (input2 != "Exit")
                        {
                            Console.WriteLine("Length: " + stack_O.Length + ". In " + stack_O.get_num_stacks() + " stacks.");
                            input = Console.ReadLine();
                            if (input == "push")
                            {
                                int pusher = Convert.ToInt32(Console.ReadLine());
                                stack_O.push(pusher);
                            }
                            if (input == "pop")
                            {
                                Console.WriteLine(stack_O.pop());
                            }
                            if (input == "popat") {
                                int popat = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(stack_O.pop_at(popat));
                            }
                                
                        }
                        break;
                }
            }
        }
    }
}
