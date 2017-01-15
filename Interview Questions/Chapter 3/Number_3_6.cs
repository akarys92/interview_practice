using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Questions.Chapter_3
{
    class Number_3_6
    {
        public Number_3_6()
        {
            Sorted_Stack S = new Sorted_Stack();
            Console.WriteLine("Use push or print");
            string input = "";
            while (input != "exit")
            {
                input = Console.ReadLine();
                if (input == "push")
                {
                    string str_in = Console.ReadLine();
                    S.push(Convert.ToInt32(str_in));
                }
                if (input == "print")
                {
                    S.print();
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
