using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class qstn5book
    {
        class book
        {
            private int BOOKNO;
            private string BOOKTITLE;
            private float PRICE;

            public void INPUT()
            {
                Console.Write("Please enter the Book.No= ");
                BOOKNO = int.Parse(Console.ReadLine());
                Console.Write("Please enter the Book Title=");
                BOOKTITLE = Console.ReadLine();
                Console.Write("Please Enter the Price=");
                PRICE = int.Parse(Console.ReadLine());
            }

            public float TOTAL_COST(int n)
            {
                float TC = PRICE * n;
                return TC;
            }

            public void PURCHASE()
            {
                Console.Write("Enter the number of copies to be purchased: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Total cost to be paid=" + TOTAL_COST(n));
            }

            public void display()
            {
                Console.WriteLine("Book.No=" + BOOKNO);
                Console.WriteLine("Book Title=" + BOOKTITLE);
                Console.WriteLine("Price=" + PRICE);
            }

            static void Main(string[] args)
            {
                book obj = new book();
                obj.INPUT();
                obj.PURCHASE();
                obj.display();
                Console.ReadLine();
            }
        }
    }
}
