using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Questions.Chapter_1
{
    // Write a method to replace all " "'s in a string with "%20"
    class Number_1_4
    {
        private string word;
        public Number_1_4(string input) {
            word = input;
        }
        public string replace_spaces() {
            // Initialize queue to hold chars
            Queue<char> temp_word = new Queue<char>();
            // Initialize count of spaces
            int count = 0;
            // Iterate through pushing letters into queue and counting spaces
            foreach (char letter in word)
            {
                if (letter == ' ')
                {
                    count++;
                    temp_word.Enqueue('%');
                    temp_word.Enqueue('2');
                    temp_word.Enqueue('0');
                }
                else {
                    temp_word.Enqueue(letter);
                }
            }
            char[] out_word = temp_word.ToArray();
            string output = new string(out_word);
            return output;
            
        }
    }
}
