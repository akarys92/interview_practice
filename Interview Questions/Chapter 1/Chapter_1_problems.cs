using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Questions.Chapter_1
{
    class Chapter_1_problems
    {
        public Chapter_1_problems() {
            string problem = "";
            while (problem != "back")
            {
                Console.WriteLine("Chapter 1: Select a problem (1..7) or 'back' to go back");
                problem = Console.ReadLine();
                switch (problem) {
                    case "1":
                        Console.WriteLine("Enter a string to be tested");
                        string test = Console.ReadLine();
                        Number_1_1 test_1_1 = new Number_1_1(test);
                        test_1_1.solve_ds();
                        break;
                    case "2":
                        Console.WriteLine("Enter a string to be reversed");
                        string to_be_rev = Console.ReadLine();
                        Number_1_2 Test_1_2 = new Number_1_2(to_be_rev);
                        Test_1_2.reverse_word();
                        break;
                    case "3":
                        Console.WriteLine("Enter 2 strings to be compared for permutation");
                        string test1 = Console.ReadLine();
                        string test2 = Console.ReadLine();
                        Number_1_3 test_1_3 = new Number_1_3(test1, test2);
                        break;
                    case "4":
                        Console.WriteLine("Enter a string to have it's ' 's replaced");
                        string input = Console.ReadLine();
                        Number_1_4 test_1_4 = new Number_1_4(input);
                        string output = test_1_4.replace_spaces();
                        Console.WriteLine(output);
                        break;
                    case "5":
                        Console.WriteLine("Enter a string to compress:");
                        string to_compress = Console.ReadLine();
                        Number_1_5 test_1_5 = new Number_1_5(to_compress);
                        Console.WriteLine(test_1_5.compress_word());
                        break;
                    case "6":
                        Matrix mat = new Matrix();
                        mat.print_matrix();
                        mat.rotate_90();
                        break;
                }           
            }
        }
    }
}
