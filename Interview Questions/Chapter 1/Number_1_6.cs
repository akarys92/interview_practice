using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Questions.Chapter_1
{
    class Number_1_6
    {
        public Number_1_6(char[][] matrix) {
        
        }
    }

    class Matrix {
        private char[,] structure;
        private int x_size;
        private int y_size;

        public Matrix() {
            structure = new char[,]{{'*','*','*','*','*','*','*','*','*','*'},
                                    {'*', '*','*','*','*', ' ','*','*','*','*'},
                                    {'*', '*','*','*','*', ' ','*','*','*','*'},
                                    {'*', '*','*','*','*', ' ',' ','*','*','*'},
                                    {'*', '*','*','*','*', ' ',' ','*','*','*'},
                                    {'*','*','*','*','*','*','*','*','*','*'} };
            x_size = 10;
            y_size = 6;
        }
        public Matrix(int in_x, int in_y)
        {
            x_size = in_x;
            y_size = in_y;
            structure = new char[y_size, x_size];
            for (int y = 0; y < y_size; y++)
            {
                for (int x = 0; x < x_size; x++)
                {
                    Console.WriteLine("Input {" + x + ", " + y + "}");
                    string input = Console.ReadLine();
                    char character = input[0];
                    structure[y, x] = character;
                }
            }
        }

        public void print_matrix() {
            for (int y = 0; y < y_size; y++)
            {
                for (int x = 0; x < x_size; x++) {
                    Console.Write(structure[y, x]);
                    Console.Write(", ");
                }
                Console.WriteLine("\n");
            }
        }
        public void rotate_90() {
            Console.WriteLine("Rotating:");
            char[,] rot_struc = new char[x_size, y_size];
            for (int y = 0; y < y_size; y++)
            {
                for (int x = 0; x < x_size; x++)
                {
                    rot_struc[x,y] = structure[y, x];
                }
            }
            int temp = x_size;
            x_size = y_size;
            y_size = temp;
            structure = rot_struc;
            print_matrix();
        }
    }
}
