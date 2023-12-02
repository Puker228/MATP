using System;

namespace lab6
{
    class Program
    {
        static void Main()
        {
            int n = 0;
            Console.Write("Количество элементов в массиве: ");
            try{n = Convert.ToInt32(Console.ReadLine());}
            catch
            {
                Console.WriteLine("Введено не число");
                return;
            }

            double[] x = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите число {0}: ", i + 1);
                try
                {
                    x[i] = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("Введено не число");
                    return;
                }
            }
            
            bool t = true;
            
            for (int i = 0; i < n - 1; i++)
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
            string error228 = "228";
        }
    }
}