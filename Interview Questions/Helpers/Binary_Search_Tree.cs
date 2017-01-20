using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Questions.Helpers
{
    class Binary_Search_Tree {
        private Tree_Node Head;
        public int depth;
        private int nodes;

        public Binary_Search_Tree() {
            Head = null;
            depth = 0;
            nodes = 0;
        }
        private void insert_helper(int input, Tree_Node root) {
            if (input >= root.Value)
            {
                if (root.Right == null)
                {
                    nodes++;
                    root.Right = new Tree_Node(input);
                }
                else {
                    insert_helper(input, root.Right);
                }
            }
            else if (input < root.Value) {
                if (root.Left == null)
                {
                    nodes++;
                    root.Left = new Tree_Node(input);
                }
                else {
                    insert_helper(input, root.Left);
                }
            }
        }
        public void insert(int input)
        {
            depth = 0;
            if (Head == null)
            {
                Head = new Tree_Node(input);
            }
            else {
                insert_helper(input, Head);
            }
            print();
        }
        public bool search(int test) {
            return search_helper(test, Head);
        }
        private bool search_helper(int test, Tree_Node root) {
            if (root == null) {
                return false;
            }
            if (root.Value == test)
            {
                return true;
            }
            else if (test >= root.Value)
            {
                return search_helper(test, root.Right);
            }
            else {
                return search_helper(test, root.Left);
            }
        }
        public void print() {
            Console.WriteLine("Depth is {0}", depth);
            Console.WriteLine("{0} total nodes in the tree.", nodes);
        }
    }
    class Tree_Node {
        public int Value { get; set; }
        public Tree_Node Left { get; set; }
        public Tree_Node Right { get; set; }
        
        public Tree_Node(int input) {
            Value = input;
            Left = null;
            Right = null;
        }
        public bool isLeaf() {
            return Right == null && Left == null;
        }
    }
}
