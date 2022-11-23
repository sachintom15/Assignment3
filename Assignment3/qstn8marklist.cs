using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{


    class Student
    {

        private int Student_Id;
        private String Student_Name;
        public void Student_Read()
        {
            Console.WriteLine("Enter Student Id :");
            Student_Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name :");
            Student_Name = Console.ReadLine();
        }
        public void Student_display()
        {
            Console.WriteLine("Student Id=" + Student_Id);
            Console.WriteLine("Student Name=" + Student_Name);
        }

        public class internals : Student
        {
            protected int marks_internal;
            public void internals_Read()
            {
                base.Student_Read();
                Console.WriteLine("Enter Marks internal =");
                marks_internal = int.Parse(Console.ReadLine());
            }
            public void internals_display()
            {
                base.Student_display();
                Console.WriteLine("Marks internal=" + marks_internal);
            }
        }
        public class externals : internals
        {
            private int Marks_external;
            private int Marks_Total;
            public void externals_Read()
            {
                internals_Read();
                Console.WriteLine("Enter Marks external");
                Marks_external = int.Parse(Console.ReadLine());
            }
            public void externals_Display()
            {
                internals_display();
                Console.WriteLine("Marks external=" + Marks_external);
            }
            public int externals_Calculate()
            {
                Marks_Total = marks_internal + Marks_external;
                return Marks_Total;
            }
        }
        class qstn8marklist
        {

            public static void Main(string[] args)
            {
                externals obje = new externals();
                obje.externals_Read();
                obje.externals_Display();
                Console.WriteLine("Total Marks =" + obje.externals_Calculate());
                Console.ReadKey();
            }
        }
    }
}
