using System;

namespace lab4
{
    class Program
    {
        static void Main()
        {
            int n; 
            Console.Write("Количество элементов в массиве: ");
            n = Convert.ToInt32 (Console.ReadLine());

            double[] x = new double[n]; 

            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите число {0}: ", i + 1);
                x[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();    
            }

            bool t = true;
            for (int i = 0; i < n-1; i++)
            {
                if (x[i] == 0)
                {
                    t = false;
                    break;
                }
                
                if ((x[i] >= 0 && x[i + 1] >= 0) || (x[i] < 0 && x[i + 1] < 0))
                {
                    t = false;
                    break;
                }
            }
            Console.WriteLine("T = {0}", t);
        }
    }

}