using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraasparameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrades = new int[] {23,54,12,44,22,3,16 };
            double averageResult = GetAverage(studentsGrades);    

            foreach (int grades in studentsGrades)
            {
                Console.WriteLine(" {0} ",grades);
            }

            Console.WriteLine("The average is: {0}" ,averageResult);
            Console.ReadKey();
        }
        static double GetAverage(int[] gradesArray)
        {
            int size=gradesArray.Length;
            int sum=0;
            double average;
            for (int i=0; i<size; i++)
            {
                sum+= gradesArray[i];
            }
            average=(double)sum/size;
            return average;
        }
    }
}
