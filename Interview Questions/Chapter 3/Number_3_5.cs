using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Questions.Chapter_3
{
    class Number_3_5
    {
        public Number_3_5() {
            Queue Q = new Queue();
            Console.WriteLine("Use push, pop or print");
            string input = "";
            while (input != "exit")
            {
                input = Console.ReadLine();
                if (input == "push")
                {
                    int pusher = Convert.ToInt32(Console.ReadLine());
                    Q.push(pusher);
                }
                if (input == "pop")
                {
                    Console.WriteLine(Q.pop());
                }
                if (input == "print")
                {
                    Q.print();
                }
            }
        }
    }
}
