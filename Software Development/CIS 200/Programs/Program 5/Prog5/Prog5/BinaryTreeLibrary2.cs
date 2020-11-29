// Program 5 EC
// CIS 200-01
// Fall 2019
// Due: 12/2/2019
// By: M3838

// Fig. 19.23: BinaryTreeLibrary2.cs
// Declaration of class TreeNode and class Tree that are Generic Classes.
using System;

namespace Prog5
{
   // class TreeNode declaration that is gereic to be comparable. 
   class TreeNode<T> where T : IComparable
   {
      // automatic property LeftNode
      public TreeNode<T> LeftNode { get; set; }

      // automatic property Data
      public IComparable Data { get; private set; }

      // automatic property RightNode
      public TreeNode<T> RightNode { get; set; }

      // initialize Data and make this a leaf node
      public TreeNode(IComparable nodeData)
      {
         Data = nodeData;
      }

      // insert TreeNode into Tree that contains nodes;
      // ignore duplicate values
      public void Insert(IComparable insertValue)
      {
         if (insertValue.CompareTo(Data) < 0) // insert in left subtree
         {
            // insert new TreeNode
            if (LeftNode == null)
            {
               LeftNode = new TreeNode<T>(insertValue);
            }
            else // continue traversing left subtree
            {
               LeftNode.Insert(insertValue);
            }
         }
         else if (insertValue.CompareTo(Data) > 0) // insert in right
         {
            // insert new TreeNode
            if (RightNode == null)
            {
               RightNode = new TreeNode<T>(insertValue);
            }
            else // continue traversing right subtree
            {
               RightNode.Insert(insertValue);
            }
         }
      }
   }

    // class Tree declaration that is Generic to be able to compare.
    public class Tree<T> where T : IComparable
    {
      private TreeNode<T> root;

      // Insert a new node in the binary search tree.
      // If the root node is null, create the root node here.
      // Otherwise, call the insert method of class TreeNode.
      public void InsertNode(IComparable insertValue)
      {
         if (root == null)
         {
            root = new TreeNode<T>(insertValue);
         }
         else
         {
            root.Insert(insertValue);
         }
      }

      // begin preorder traversal
      public void PreorderTraversal()
      {
         PreorderHelper(root);
      }

      // recursive method to perform preorder traversal
      private void PreorderHelper(TreeNode<T> node)
      {
         if (node != null)
         {
            // output node Data
            Console.Write($"{node.Data} ");

            // traverse left subtree
            PreorderHelper(node.LeftNode);

            // traverse right subtree
            PreorderHelper(node.RightNode);
         }
      }

      // begin inorder traversal
      public void InorderTraversal()
      {
         InorderHelper(root);
      }

      // recursive method to perform inorder traversal
      private void InorderHelper(TreeNode<T> node)
      {
         if (node != null)
         {
            // traverse left subtree
            InorderHelper(node.LeftNode);

            // output node data
            Console.Write($"{node.Data} ");

            // traverse right subtree
            InorderHelper(node.RightNode);
         }
      }

      // begin postorder traversal
      public void PostorderTraversal()
      {
         PostorderHelper(root);
      }

      // recursive method to perform postorder traversal
      private void PostorderHelper(TreeNode<T> node)
      {
         if (node != null)
         {
            // traverse left subtree
            PostorderHelper(node.LeftNode);

            // traverse right subtree
            PostorderHelper(node.RightNode);

            // output node Data
            Console.Write($"{node.Data} ");
         }
      }
   }
}


/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
