using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Questions.Chapter_3
{
    class Number_3_2 : Stack
    {
        public int Min { get; private set; }
        private Stack min_stack;

        public Number_3_2() : base() {
            min_stack = new Stack();
        }
        public void push(int val) {
            if (val < Min || Length == 0)
            {
                Min = val;
                min_stack.push(val);
            }
            else {
                min_stack.push(Min);
            }
            base.push(val);
        }
        public int pop() {
            int val = base.pop();
            int min_val = min_stack.pop();
            if (val < min_val) {
                Min = val;
            }
            return val;
        }
        public int get_min() {
            return min_stack.peek();
        }

    }
}
