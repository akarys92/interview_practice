using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Questions.Chapter_3
{
    // The stack
    class Stack
    {
        private stack_node head { get; set; }
        public int Length { get; set; }

        public Stack() {
            Length = 0;
            head = null;
        }
        public Stack(int first) {
            head = new stack_node(first);
            Length = 0;
        }
        public void push(int value) {
            stack_node new_node = new stack_node(value, head);
            head = new_node;
            Length++;
        }
        public int pop() {
            if (Length < 1) {
                throw new System.ArgumentException("Cannot pop an empty stack!");
            }
            stack_node temp = head;
            head = temp.next;
            Length--;
            return temp.value;
        }
        public void print_stack() {
            stack_node temp = head;
            Console.Write("Head->");
            
            while (temp != null) {
                Console.Write(temp.value + " ");
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }
        // Stack node class
        class stack_node
        {
            public int value { get; set; }
            public stack_node next { get; set; }

            public stack_node(int val)
            {
                value = val;
            }
            public stack_node(int val, stack_node next_node)
            {
                value = val;
                next = next_node;
            }
        }
    }
}
