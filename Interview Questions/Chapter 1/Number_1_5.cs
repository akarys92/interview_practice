using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Questions.Chapter_1
{
    //Implement a method to perform basic string compression using the counts of repeated charaters for example the string aabcccccaaa would be a2b1c5a3. If the string would not become smaller by compression, return the original string.
    class Number_1_5
    {
        private string word;
        public Number_1_5(string input) {
            word = input;
        }

        public string compress_word() {

            // Iterate through the word, keep track of the current letter
            // If the current letter is the same as curr_letter, iterate counter
            // If not push the letter with count
            // Check if the new word is longer
            return "Not implemented";
        }
    }
}
