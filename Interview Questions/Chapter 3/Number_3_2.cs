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

        public Number_3_2() : base() { }
        public void push(int val) {
            if (val < Min) {
                Min = val;
            }
            base.push(val);
        }
        public int pop() {
            // TODO: Need to update min here somehow...
            int val = base.pop();
            return val;

        }

    }
}
