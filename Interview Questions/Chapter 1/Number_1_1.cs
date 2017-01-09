using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Questions.Chapter_1
{
    // Implement an algorithm to determine if a string has all unique characters. 
    // What if you cannot use additional data structures?
    class Number_1_1
    {
        private string word;
        public Number_1_1(string input) {
            word = input;
        }
        public bool solve_no_ds() {
            string lower = word.ToLower();
            char start = 'a';
            for (; start < 'z'; start++) {
                int count = 0;
                foreach(char letter in lower) {
                    if (letter == start) {
                        count++;
                    }
                    if(count > 1)
                    {
                        Console.WriteLine("False, failed on " + start);
                        return false;
                    }
                }
            }
            Console.WriteLine("True, no repeats");
            return true;
        }
        public bool solve_ds() {
            Byte[] tracker = new Byte[26];
            string lower = word.ToLower();
            foreach (char letter in lower) {
                int index = (int) letter;
                index = index - 97;
                if (tracker[index] != 1) {
                    tracker[index] = 1;
                }
                else if (tracker[index] == 1) {
                    Console.WriteLine("False!");
                    return false;
                }
            }
            Console.WriteLine("True!");
            return true;
        }
    }
}

