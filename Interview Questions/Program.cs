using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interview_Questions.Chapter_1;


namespace Interview_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            string problem = "";
            while (problem != "exit")
            {
                Console.WriteLine("Chapter 1");
                problem = Console.ReadLine();

                if (problem == "1")
                {
                    Console.WriteLine("Enter a string to be tested");
                    string test = Console.ReadLine();
                    Number_1_1 test_1_1 = new Number_1_1(test);
                    test_1_1.solve_ds();
                }
                else if (problem == "2")
                {
                    Console.WriteLine("Enter a string to be reversed");
                    string test = Console.ReadLine();
                    Number_1_2 Test_1_2 = new Number_1_2(test);
                    Test_1_2.reverse_word();
                }
                else if (problem == "3")
                {
                    Console.WriteLine("Enter 2 strings to be compared for permutation");
                    string test1 = Console.ReadLine();
                    string test2 = Console.ReadLine();
                    Number_1_3 test_1_3 = new Number_1_3(test1, test2);
                }
                else if (problem == "4")
                {
                    Console.WriteLine("Enter a string to have it's ' 's replaced");
                    string input = Console.ReadLine();
                    Number_1_4 test_1_4 = new Number_1_4(input);
                    string output = test_1_4.replace_spaces();
                    Console.WriteLine(output);
                }
                else if (problem == "5")
                {
                    Console.WriteLine("Enter a string to compress:");
                    string input = Console.ReadLine();
                    Number_1_5 test_1_5 = new Number_1_5(input);
                    Console.WriteLine(test_1_5.compress_word());
                }
                else if (problem == "6") {
                    Matrix mat = new Matrix();
                    mat.print_matrix();
                    mat.rotate_90();
                }
            }
        }
    }
}
