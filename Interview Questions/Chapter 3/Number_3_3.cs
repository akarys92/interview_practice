using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Questions.Chapter_3
{
    class Number_3_3
    {
        public Number_3_3() {
            Console.WriteLine("Creating stack...");
            Stack_of_Stacks stack = new Stack_of_Stacks();
            for (int i = 0; i < 30; i++) {
                stack.push(i);
            }
            Console.WriteLine("Use 'push' to push, 'pop' to pop, and 'popat' to pop at a specific stack");
            string input2 = "";
            while (input2 != "Exit")
            {
                Console.WriteLine("Length: " + stack.Length + ". In " + stack.get_num_stacks() + " stacks.");
                string input = Console.ReadLine();
                if (input == "push")
                {
                    int pusher = Convert.ToInt32(Console.ReadLine());
                    stack.push(pusher);
                }
                if (input == "pop")
                {
                    Console.WriteLine(stack.pop());
                }
                if (input == "popat")
                {
                    int popat = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(stack.pop_at(popat));
                }
                if (input == "print")
                {
                    stack.print();
                }
            }
        }
    }
}
