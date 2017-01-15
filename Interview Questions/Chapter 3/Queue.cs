using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Questions.Chapter_3
{
    class Queue
    {
        Stack[] queue;
        int active;
        public Queue() {
            queue = new Stack[2];
            queue[0] = new Stack();
            queue[1] = new Stack();
            active = 0;
        }
        public void push(int input)
        {
            queue[active].push(input);
        }
        public int pop() {
            reverse();
            int ret = queue[active].pop();
            reverse();
            return ret;
        }
        public void print()
        {
            queue[active].print_stack();
        }
        private void reverse() {
            int inactive = get_inactive();
            while (queue[active].Length > 0) {
                int temp = queue[active].pop();
                queue[inactive].push(temp);
            }
            active = inactive;
        }
        private int get_inactive() {
            if (active == 1) { return 0; }
            return 1;
        }
    }
}
