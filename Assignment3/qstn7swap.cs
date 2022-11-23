using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{


    class Swap
    {
        public int id;
        public string name;
        public int mark;
        public void read()
        {
            Console.WriteLine("Enter the Student id=");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Student Name=");
            name = Console.ReadLine();
            Console.WriteLine("Enter the mark=");
            mark = int.Parse(Console.ReadLine());
        }
        public void swap(Swap S1, Swap S2)
        {
            Swap temp = new Swap();
            temp = S1;
            S1 = S2;
            S2 = temp;
        }
        public void display()
        {
            Console.WriteLine("Id=" + id);
            Console.WriteLine("Name=" + name);
            Console.WriteLine("Mark=" + mark);
        }
    }
    class qstn7swap
    {

        static void Main(string[] args)
        {
            Swap s1 = new Swap();
            Swap s2 = new Swap();
            s1.read();
            s2.read();
            Console.WriteLine("Details Before Swapping =");
            s1.display();
            s2.display();
            s1.swap(s1, s2);
            Console.WriteLine("Details After Swapping =");
            s1.display();
            s2.display();
            Console.ReadLine();
        }

    }
}
