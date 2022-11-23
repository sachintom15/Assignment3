using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class qstn4stackoperations
    {
        static void Main(string[] args)
        {
            int top = -1;
            int[] size = new int[10];
            Console.WriteLine("Enter the stack size");
            int max = Convert.ToInt16(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("1.Push");
                Console.WriteLine("2.Pop");
                Console.WriteLine("3.Display");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Please enter your choice=");
                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        if (top >= max - 1)
                        {
                            Console.WriteLine("Stack Overflow");
                        }

                        else
                        {
                            Console.WriteLine("Enter the item :");
                            int n = int.Parse(Console.ReadLine());
                            size[++top] = n;
                        }
                        break;
                    case 2:
                        if (top == -1)
                        {
                            Console.WriteLine("Stack Underflow");
                        }
                        else
                        {
                            Console.WriteLine("Popped item :" + size[top--]);
                        }
                        break;
                    case 3:
                        if (top == -1)
                        {
                            Console.WriteLine("Stack underflow");
                        }
                        else
                        {
                            Console.WriteLine("Elements in the stack");
                            for (int i = top; i >= 0; i--)
                            {
                                Console.WriteLine(size[i]);
                            }
                        }
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
