using System;
using System.Collections.Generic;

namespace binary_trees
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<QuizItem> tree = GetTree();
            BinaryTreeNode<QuizItem> node = tree.Root;

            var test = tree.Traverse(TraversalEnum.CUSTOM);
            foreach (var item in test)
            {
                Console.WriteLine(item.Data.Text);
            }

            Console.ReadLine();
            //while (node != null)
            //{
            //    if (node.Left != null || node.Right != null)
            //    {
            //        Console.Write(node.Data.Text);
            //        switch (Console.ReadKey(true).Key)
            //        {
            //            case ConsoleKey.Y:
            //                WriteAnswer(" Yes");
            //                node = node.Left;
            //                break;
            //            case ConsoleKey.N:
            //                WriteAnswer(" No");
            //                node = node.Right;
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        WriteAnswer(node.Data.Text);
            //        node = null;
            //    }
            //}
        }

        //private static BinaryTree<QuizItem> GetTree()
        //{
        //    BinaryTree<QuizItem> tree = new BinaryTree<QuizItem>();
        //    tree.Root = new BinaryTreeNode<QuizItem>()
        //    {
        //        Data = new QuizItem("Do you have experience in developing applications?"),

        //        Children = new List<TreeNode<QuizItem>>()
        //        {
        //            new BinaryTreeNode<QuizItem>()
        //            {
        //                Data = new QuizItem("Have you worked as a developer for more than 5 years?"),
        //                Children = new List<TreeNode<QuizItem>>()
        //                {
        //                    new BinaryTreeNode<QuizItem>()
        //                    {
        //                        Data = new QuizItem("Apply as a senior developer!")
        //                    },
        //                    new BinaryTreeNode<QuizItem>()
        //                    {
        //                        Data = new QuizItem("Apply as a middle developer!")
        //                    }
        //                }
        //            },
        //            new BinaryTreeNode<QuizItem>()
        //            {
        //                Data = new QuizItem("Have you completed the university?"),
        //                Children = new List<TreeNode<QuizItem>>()
        //                {
        //                    new BinaryTreeNode<QuizItem>()
        //                    {
        //                        Data = new QuizItem("Apply for a junior developer!")
        //                    },
        //                    new BinaryTreeNode<QuizItem>()
        //                    {
        //                        Data = new QuizItem("Will you find some time during the semester?"),
        //                        Children = new List<TreeNode<QuizItem>>()
        //                        {
        //                            new BinaryTreeNode<QuizItem>()
        //                            {
        //                                Data = new QuizItem("Apply for our long-time internship program!")
        //                            },
        //                            new BinaryTreeNode<QuizItem>()
        //                            {
        //                                Data = new QuizItem("Apply for summer internship program!")
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    };
        //    tree.Count = 9;
        //    return tree;
        //}

        private static BinaryTree<QuizItem> GetTree()
        {
            BinaryTree<QuizItem> tree = new BinaryTree<QuizItem>();
            tree.Root = new BinaryTreeNode<QuizItem>()
            {
                Data = new QuizItem("1"),

                Children = new List<TreeNode<QuizItem>>()
                {
                    new BinaryTreeNode<QuizItem>()
                    {
                        Data = new QuizItem("2"),
                        Children = new List<TreeNode<QuizItem>>()
                        {
                            new BinaryTreeNode<QuizItem>()
                            {
                                Data = new QuizItem("3")
                            },
                            new BinaryTreeNode<QuizItem>()
                            {
                                Data = new QuizItem("4")
                            }
                        }
                    },
                    new BinaryTreeNode<QuizItem>()
                    {
                        Data = new QuizItem("5"),
                        Children = new List<TreeNode<QuizItem>>()
                        {
                            new BinaryTreeNode<QuizItem>()
                            {
                                Data = new QuizItem("6")
                            },
                            new BinaryTreeNode<QuizItem>()
                            {
                                Data = new QuizItem("7"),
                                Children = new List<TreeNode<QuizItem>>()
                                {
                                    new BinaryTreeNode<QuizItem>()
                                    {
                                        Data = new QuizItem("8")
                                    },
                                    new BinaryTreeNode<QuizItem>()
                                    {
                                        Data = new QuizItem("9")
                                    }
                                }
                            }
                        }
                    }
                }
            };
            tree.Count = 9;
            return tree;
        }

        private static void WriteAnswer(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}