using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Questions.Chapter_3
{
    class Number_3_4
    {
        private string dir;
        private Stack A;
        private Stack B;
        private Stack C;
        private int steps;
        /* IF Even:
         *  AB, AC, BC
         * IF Odd:
         *  AC, AB, BC 
         */
        public Number_3_4(int objs) {
            A = new Stack(0);
            B = new Stack(0);
            C = new Stack(0);
            steps = 0;
            for (int i = objs; i > 0; i--) {
                A.push(i);
            }
            if (objs % 2 == 0)
            {
                dir = "even";
            }
            else {
                dir = "odd";
            }
            print_board();
            play();
            Console.WriteLine("Took " + Convert.ToString(steps) + " steps");
        }
        public void play() {
            if (dir == "even")
            {
                play_even();
            }
            else {
                play_odd();
            }
        }
        private void play_even() {
            while (!check_board()) {
                A_B_Play();
                if (check_board()) { break; }
                A_C_Play();
                if (check_board()) { break; }
                B_C_Play();
                if (check_board()) { break; }
                print_board();
            }
            print_board();
        }
        private void play_odd() {
            while (!check_board())
            {
                A_C_Play();
                if (check_board()) { break; }
                A_B_Play();
                if (check_board()) { break; }
                B_C_Play();
                if (check_board()) { break; }
                print_board();
            }
            print_board();
        }
        public void print_board() {
            A.print_stack();
            Console.Write("   ");
            B.print_stack();
            Console.Write("   ");
            C.print_stack();
            Console.Write("\n");
        }
        private void A_B_Play() {
            // Peek a and b. If A < B push a to B
            int A_val = A.peek();
            int B_val = B.peek();
            if (A_val != 0 && A_val < B_val || B_val == 0)
            {
                A_val = A.pop();
                B.push(A_val);
            }
            else {
                B_val = B.pop();
                A.push(B_val);
            }
            print_board();
            steps++;
        }
        private void A_C_Play()
        {
            // Peek a and b. If A < B push a to B
            int A_val = A.peek();
            int C_val = C.peek();
            if (A_val != 0 && A_val < C_val || C_val == 0)
            {
                A_val = A.pop();
                C.push(A_val);
            }
            else
            {
                C_val = C.pop();
                A.push(C_val);
            }
            print_board();
            steps++;
        }
        private void B_C_Play()
        {
            // Peek a and b. If A < B push a to B
            int C_val = C.peek();
            int B_val = B.peek();
            if (C_val != 0 && C_val < B_val || B_val == 0)
            {
                C_val = C.pop();
                B.push(C_val);
            }
            else
            {
                B_val = B.pop();
                C.push(B_val);
            }
            print_board();
            steps++;
        }
        private bool check_board() {
            return A.Length == 1 && B.Length == 1;
        }
    }
}
