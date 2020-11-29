// Program 5 EC
// CIS 200-01
// Fall 2019
// Due: 12/2/2019
// By: M3838

// TreeTestProg.cs
// Shows the arrays and orders them through the Generic Classes and display them. 
using System;
using static System.Console;

namespace Prog5
{
    class TreeTestProg
    {
        // test class Tree
        static void Main(string[] arg)
        {
            int[] intArray = { 8, 2, 4, 3, 1, 7, 5, 6, 22, 11, 0, 10};
            double[] doubleArray = { 8.8, 2.2, 4.4, 3.3, 1.1, 7.7, 5.5, 6.6, 10.10, 0.0, 1.11, 22.22 };
            string[] stringArray = {"Jamee", "Myung", "Era", "Genesis", "Keisha", "Danyell", "Armando", "Mavis", "Bryce", "Shari", "Lulu", "Azerl" };

            
            // create int Tree
            Tree<double> intTree = new Tree<double>();
            PopulateTree(intArray, intTree, nameof(intTree));
            TraverseTree(intTree, nameof(intTree));

            // create double Tree
            Tree<double> doubleTree = new Tree<double>();
            PopulateTree(doubleArray, doubleTree, nameof(doubleTree));
            TraverseTree(doubleTree, nameof(doubleTree));

            // create string Tree
            Tree<double> stringTree = new Tree<double>();
            PopulateTree(stringArray, stringTree, nameof(stringTree));
            TraverseTree(stringTree, nameof(stringTree));
        }

        // populate Tree with array elements
        private static void PopulateTree<T>(T[] array, Tree<double> tree, string name)
        {
            WriteLine($"\n\n\nInserting into {name}:");
                ForegroundColor = ConsoleColor.Cyan;
            foreach (IComparable data in array)
            {
                    Write($"{data} ");
                    tree.InsertNode(data);
            }
        }

        // perform traversals
        private static void TraverseTree(Tree<double> tree, string treeType)
        {
            ForegroundColor = ConsoleColor.White;
            // perform inorder traversal of tree
            WriteLine($"\n\nInorder traversal of {treeType}:");
            ForegroundColor = ConsoleColor.Cyan;
            tree.InorderTraversal();
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            Pause();
        }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            WriteLine("Press Enter to Continue...");
            ReadLine();

            Clear(); // Clear screen
        }
    }
}
