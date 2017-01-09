using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Questions.Chapter_1
{
    //Implement a function void reverse (char* str) that reverses a null terminated string?
    class Number_1_2
    {
        private string word;
        public Number_1_2(string input)
        {
            word = input;
        }
        public string reverse_word() {
            // Get array size as 'end_index'
            int size = word.Length;
            // Initialize new word
            char[] output = new char[size];
            // Initialize 'start_index' at 0
            int start_index = 0;
            int end_index = size - 1;
            // Iterate through swap start_index and end index until they are equal
            while(start_index <= end_index)
            {
                output[start_index] = word[end_index];
                output[end_index] = word[start_index];
                // Increment start_index decremeent end_index
                start_index++;
                end_index--;
            }
            // Convert back to string
            string out_string = new string(output);
            Console.WriteLine(out_string);
            return out_string;

        }
    }
}
