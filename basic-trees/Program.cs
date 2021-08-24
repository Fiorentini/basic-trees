using System;
using System.Collections.Generic;

namespace basic_trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>();
            tree.Root = new TreeNode<int>() { Data = 1 };
            tree.Root.Children = new List<TreeNode<int>>
            {
                new TreeNode<int>() { Data = 2, Parent = tree.Root },
                new TreeNode<int>() { Data = 3, Parent = tree.Root }
            };

            tree.Root.Children[0].Children = new List<TreeNode<int>>()
            {
                new TreeNode<int>()
                    { Data = 4, Parent = tree.Root.Children[0] }
            };

            Console.WriteLine(tree.Root.Children[0].GetHeight());
            Console.ReadLine();
        }
    }
}
