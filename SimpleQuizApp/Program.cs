using System;
using System.Collections.Generic;
namespace SimpleQuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            BinaryTree<QuizItem> quizItemTree = GetTree();
            BinaryTreeNode<QuizItem> node = quizItemTree.Root;
            while (node!=null)
            {
                if (node.Left !=null || node.Right !=null)
                {
                    Console.Write(node.Data.Text);
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.Backspace:
                            break;
                        case ConsoleKey.Tab:
                            break;
                        case ConsoleKey.Clear:
                            break;
                        case ConsoleKey.Enter:
                            break;
                        case ConsoleKey.Pause:
                            break;
                        case ConsoleKey.Escape:
                            break;
                        case ConsoleKey.Spacebar:
                            break;
                        case ConsoleKey.PageUp:
                            break;
                        case ConsoleKey.PageDown:
                            break;
                        case ConsoleKey.End:
                            break;
                        case ConsoleKey.Home:
                            break;
                        case ConsoleKey.LeftArrow:
                            break;
                        case ConsoleKey.UpArrow:
                            break;
                        case ConsoleKey.RightArrow:
                            break;
                        case ConsoleKey.DownArrow:
                            break;
                        case ConsoleKey.Select:
                            break;
                        case ConsoleKey.Print:
                            break;
                        case ConsoleKey.Execute:
                            break;
                        case ConsoleKey.PrintScreen:
                            break;
                        case ConsoleKey.Insert:
                            break;
                        case ConsoleKey.Delete:
                            break;
                        case ConsoleKey.Help:
                            break;
                        case ConsoleKey.D0:
                            break;
                        case ConsoleKey.D1:
                            break;
                        case ConsoleKey.D2:
                            break;
                        case ConsoleKey.D3:
                            break;
                        case ConsoleKey.D4:
                            break;
                        case ConsoleKey.D5:
                            break;
                        case ConsoleKey.D6:
                            break;
                        case ConsoleKey.D7:
                            break;
                        case ConsoleKey.D8:
                            break;
                        case ConsoleKey.D9:
                            break;
                        case ConsoleKey.A:
                            break;
                        case ConsoleKey.B:
                            break;
                        case ConsoleKey.C:
                            break;
                        case ConsoleKey.D:
                            break;
                        case ConsoleKey.E:
                            break;
                        case ConsoleKey.F:
                            break;
                        case ConsoleKey.G:
                            break;
                        case ConsoleKey.H:
                            break;
                        case ConsoleKey.I:
                            break;
                        case ConsoleKey.J:
                            break;
                        case ConsoleKey.K:
                            break;
                        case ConsoleKey.L:
                            break;
                        case ConsoleKey.M:
                            break;
                        case ConsoleKey.N:
                            WriteAnswer("No");
                            node = node.Right;
                            break;
                        case ConsoleKey.O:
                            break;
                        case ConsoleKey.P:
                            break;
                        case ConsoleKey.Q:
                            break;
                        case ConsoleKey.R:
                            break;
                        case ConsoleKey.S:
                            break;
                        case ConsoleKey.T:
                            break;
                        case ConsoleKey.U:
                            break;
                        case ConsoleKey.V:
                            break;
                        case ConsoleKey.W:
                            break;
                        case ConsoleKey.X:
                            break;
                        case ConsoleKey.Y:
                            WriteAnswer("Yes");
                            node = node.Left;
                            break;
                        case ConsoleKey.Z:
                            break;
                        case ConsoleKey.LeftWindows:
                            break;
                        case ConsoleKey.RightWindows:
                            break;
                        case ConsoleKey.Applications:
                            break;
                        case ConsoleKey.Sleep:
                            break;
                        case ConsoleKey.NumPad0:
                            break;
                        case ConsoleKey.NumPad1:
                            break;
                        case ConsoleKey.NumPad2:
                            break;
                        case ConsoleKey.NumPad3:
                            break;
                        case ConsoleKey.NumPad4:
                            break;
                        case ConsoleKey.NumPad5:
                            break;
                        case ConsoleKey.NumPad6:
                            break;
                        case ConsoleKey.NumPad7:
                            break;
                        case ConsoleKey.NumPad8:
                            break;
                        case ConsoleKey.NumPad9:
                            break;
                        case ConsoleKey.Multiply:
                            break;
                        case ConsoleKey.Add:
                            break;
                        case ConsoleKey.Separator:
                            break;
                        case ConsoleKey.Subtract:
                            break;
                        case ConsoleKey.Decimal:
                            break;
                        case ConsoleKey.Divide:
                            break;
                        case ConsoleKey.F1:
                            break;
                        case ConsoleKey.F2:
                            break;
                        case ConsoleKey.F3:
                            break;
                        case ConsoleKey.F4:
                            break;
                        case ConsoleKey.F5:
                            break;
                        case ConsoleKey.F6:
                            break;
                        case ConsoleKey.F7:
                            break;
                        case ConsoleKey.F8:
                            break;
                        case ConsoleKey.F9:
                            break;
                        case ConsoleKey.F10:
                            break;
                        case ConsoleKey.F11:
                            break;
                        case ConsoleKey.F12:
                            break;
                        case ConsoleKey.F13:
                            break;
                        case ConsoleKey.F14:
                            break;
                        case ConsoleKey.F15:
                            break;
                        case ConsoleKey.F16:
                            break;
                        case ConsoleKey.F17:
                            break;
                        case ConsoleKey.F18:
                            break;
                        case ConsoleKey.F19:
                            break;
                        case ConsoleKey.F20:
                            break;
                        case ConsoleKey.F21:
                            break;
                        case ConsoleKey.F22:
                            break;
                        case ConsoleKey.F23:
                            break;
                        case ConsoleKey.F24:
                            break;
                        case ConsoleKey.BrowserBack:
                            break;
                        case ConsoleKey.BrowserForward:
                            break;
                        case ConsoleKey.BrowserRefresh:
                            break;
                        case ConsoleKey.BrowserStop:
                            break;
                        case ConsoleKey.BrowserSearch:
                            break;
                        case ConsoleKey.BrowserFavorites:
                            break;
                        case ConsoleKey.BrowserHome:
                            break;
                        case ConsoleKey.VolumeMute:
                            break;
                        case ConsoleKey.VolumeDown:
                            break;
                        case ConsoleKey.VolumeUp:
                            break;
                        case ConsoleKey.MediaNext:
                            break;
                        case ConsoleKey.MediaPrevious:
                            break;
                        case ConsoleKey.MediaStop:
                            break;
                        case ConsoleKey.MediaPlay:
                            break;
                        case ConsoleKey.LaunchMail:
                            break;
                        case ConsoleKey.LaunchMediaSelect:
                            break;
                        case ConsoleKey.LaunchApp1:
                            break;
                        case ConsoleKey.LaunchApp2:
                            break;
                        case ConsoleKey.Oem1:
                            break;
                        case ConsoleKey.OemPlus:
                            break;
                        case ConsoleKey.OemComma:
                            break;
                        case ConsoleKey.OemMinus:
                            break;
                        case ConsoleKey.OemPeriod:
                            break;
                        case ConsoleKey.Oem2:
                            break;
                        case ConsoleKey.Oem3:
                            break;
                        case ConsoleKey.Oem4:
                            break;
                        case ConsoleKey.Oem5:
                            break;
                        case ConsoleKey.Oem6:
                            break;
                        case ConsoleKey.Oem7:
                            break;
                        case ConsoleKey.Oem8:
                            break;
                        case ConsoleKey.Oem102:
                            break;
                        case ConsoleKey.Process:
                            break;
                        case ConsoleKey.Packet:
                            break;
                        case ConsoleKey.Attention:
                            break;
                        case ConsoleKey.CrSel:
                            break;
                        case ConsoleKey.ExSel:
                            break;
                        case ConsoleKey.EraseEndOfFile:
                            break;
                        case ConsoleKey.Play:
                            break;
                        case ConsoleKey.Zoom:
                            break;
                        case ConsoleKey.NoName:
                            break;
                        case ConsoleKey.Pa1:
                            break;
                        case ConsoleKey.OemClear:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    WriteAnswer(node.Data.Text);
                    node = null;
                }
            }
        }

        private static BinaryTree<QuizItem> GetTree()
        {
            BinaryTree<QuizItem> quizItemTree = new BinaryTree<QuizItem>();
            quizItemTree.Root = new BinaryTreeNode<QuizItem>()
            {
                Data = new QuizItem("Do you have experience in developing applications?"),
                Child = new List<TreeNode<QuizItem>>()
                {
                    new BinaryTreeNode<QuizItem>()
                    {
                        Data = new QuizItem("Have you worked as a developer for more than 5 years?"),
                        Child = new List<TreeNode<QuizItem>>()
                        {
                            new BinaryTreeNode<QuizItem>()
                            {
                                Data = new QuizItem("Apply as a senior developer!")
                            },
                            new BinaryTreeNode<QuizItem>()
                            {
                                Data = new QuizItem("Apply as a mid level developer!")
                            }
                        }
                    },
                    new BinaryTreeNode<QuizItem>()
                    {
                        Data = new QuizItem("Have you completed the University?"),
                        Child = new List<TreeNode<QuizItem>>()
                        {
                            new BinaryTreeNode<QuizItem>()
                            {
                                Data = new QuizItem("Apply for a junior developer!")
                            },
                            new BinaryTreeNode<QuizItem>()
                            {
                                Data = new QuizItem("Will you find sometime during semester?"),
                                Child = new List<TreeNode<QuizItem>>()
                                {
                                   new BinaryTreeNode<QuizItem>()
                                    {
                                        Data = new QuizItem("Apply for our long-term internship program!")
                                    },
                                   new BinaryTreeNode<QuizItem>()
                                    {
                                        Data = new QuizItem("Apply for summer internship program!")
                                    },
                                }
                            },
                        }
                    }
                }
            };

            quizItemTree.Count = 9;
            return quizItemTree;
        }

        private static void WriteAnswer(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
