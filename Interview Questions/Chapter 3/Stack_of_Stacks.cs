using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Questions.Chapter_3
{
    // If a stack needs to be less than a length of MAX_SIZE, this implementation will give the illusion of a single Stack, 
    // but will be limited to stacks of size MAZ_SIZE
    class Stack_of_Stacks
    {
        private Stack_O_Node head { get; set; }
        private static int MAX_SIZE = 2;
        public int Length { get; private set; }
        private int num_stacks;

        public Stack_of_Stacks() {
            head = new Stack_O_Node();
            num_stacks = 1;
            Length = 0;
        }
        public void push(int value) {
            if (head.Length >= MAX_SIZE) {
                Stack_O_Node new_node = new Stack_O_Node();
                new_node.next = head;
                head = new_node;
                num_stacks++;
            }
            head.curr.push(value);
            Length++;
        }
        public int pop() {
            if (Length <= 0 && num_stacks <= 0) {
                throw new ArgumentException("Can't pop empty stack!");
            }
            if (head.Length <= 0) {
                head = head.next;
                num_stacks--;
            }
            Length--;
            return head.curr.pop();
        }
        public int pop_at(int index) {
            if (index >= num_stacks || index < 0) {
                throw new System.ArgumentException("No stack exists at this index");
            }
            // Iterate to the appropriate stack, pop it hold the value. Keep track of the trailing Node.
            int i = 0;
            Stack_O_Node temp = head;
            Stack_O_Node trailing = temp;
            while (i < index) {
                trailing = temp;
                temp = temp.next;
                i++;
            }
            int ret_val = temp.curr.pop();
            Length--;
            // If popped stack is now empty, remove it
            if (temp.curr.Length <= 0) {
                trailing.next = temp.next;
                num_stacks--;
            }
            return ret_val;  
        }
        public void print() {
            Stack_O_Node temp = head;
            while (temp != null) {
                temp.curr.print_stack();
                temp = temp.next;
            }
        }

        // Testing, remove this later
        public int get_num_stacks() {
            return num_stacks;
        }

        class Stack_O_Node {
            public Stack curr { get; set; }
            public int Length {
                get { return curr.Length; }
                private set { }
            }
            public Stack_O_Node next { get; set; }

            public Stack_O_Node() {
                curr = new Stack();
            }
        }
    }
}
