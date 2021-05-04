namespace CodeNestLab4.classes
{
    public class Calculator
    {
         public static double CgpaCalc(double[] marks, int n)
        {
            double[] grade = new double[n];
            double cgpa, sum = 0;    
            for (int i = 0; i < n; i++)
            {
                grade[i] = (marks[i] / 10);
                sum += grade[i];
            }
            cgpa = sum / n;
            return cgpa;
        }

    }
}