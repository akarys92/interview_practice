using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Questions.Chapter_1
{
    // Given two strings write a method to decide if one is a permutation of the other?
    class Number_1_3
    {
        public Number_1_3(string first, string second) {
            int[] map1 = create_map(first);
            int[] map2 = create_map(second);
            if (check_arrays(map1, map2))
            {
                Console.WriteLine("Permutation found");
            }
            else {
                Console.WriteLine("No permutation found");
            }
        }
        private int[] create_map(string input) {
            int[] map = new int[26];
            for (int i = 0; i < map.Length; i++) { map[i] = 0; }
            foreach (char letter in input) {
                int index = (int)letter;
                index = index - 97;
                map[index]++;
            }
            return map;
        }
        private bool check_arrays(int[] first, int[] second) {
            if (first.Length != second.Length) {
                return false;
            }
            for (int i = 0; i < first.Length; i++) {
                if (first[i] != second[i]) {
                    return false;
                }
            }
            return true;
        }
    }
}
