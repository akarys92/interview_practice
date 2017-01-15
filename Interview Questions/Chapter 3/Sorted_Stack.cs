using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Questions.Chapter_3
{
    class Sorted_Stack
    {
        Stack primary;
        Stack helper;
        public Sorted_Stack() {
            // On push, pop active stack, compare input with pop, if it is less push input, if it is greater keep popping and comparing
            // Reverse 
            primary = new Stack();
            helper = new Stack();            
        }
        public void push(int input) {
            int max = input;
            while (primary.Length >= 0)
            {
                if (primary.Length == 0) {
                    helper.push(max);
                    break;
                }
                int pop = primary.pop();
                if (pop < max)
                {
                    helper.push(pop);
                }
                else if (pop >= max) {
                    helper.push(max);
                    max = pop;
                }
            }
            // call input Max
            // Pop list, if pop > Max => helper.push(Max); Max = pop;
            //1 2 5 <= 4
                    
            while (helper.Length > 0)
            {
                primary.push(helper.pop());
            }
            
        }
        public void print()
        {
            primary.print_stack();
        }
    }
}
