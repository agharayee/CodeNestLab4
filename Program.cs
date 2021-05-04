using System;
using CodeNestLab4.classes;

namespace CodeNestLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] marks = new double[5];
            int n = 5;
            

            Console.WriteLine("This is a GradePoint Calculator, Please we can handle only 5 values for now, But we promise to improve our system shortly");
            
            double num1 = 0;
            Console.WriteLine("Please Enter the First Grade");
            bool convert = double.TryParse(Console.ReadLine(), out num1);
            marks[0] = num1;

            double num2;
            Console.WriteLine("Please Enter the Second Grade");
            bool convert2 = double.TryParse(Console.ReadLine(), out num2);
            marks[1] = num2;

            double num3;
            Console.WriteLine("Please Enter the Third Grade");
            bool convert3 = double.TryParse(Console.ReadLine(), out num3);
            marks[2] = num3;

            double num4 = 0;
            Console.WriteLine("Please Enter the Fourth Grade");
            bool convert4 = double.TryParse(Console.ReadLine(), out num4);
            marks[3] = num4;

            double num5 = 0;
            Console.WriteLine("Please Enter the fifth Grade");
            bool convert5 = double.TryParse(Console.ReadLine(), out num5);
            marks[4] = num5;
            double cgpa = Calculator.CgpaCalc(marks, n);

            Console.WriteLine("CGPA = " + cgpa);
            Console.WriteLine("CGPA Percentage = {0:F2}", cgpa * 9.5);
        }
    }
}
