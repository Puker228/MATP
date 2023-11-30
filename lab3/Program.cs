using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            double v, y, z, dy;
            string choice;
            do
            { 
                Console.Write("y = ");
                y = Convert.ToDouble(Console.ReadLine());

                Console.Write("v = ");
                v = Convert.ToDouble(Console.ReadLine());

            
                Console.Write("Каким циклом решить? \n 1) while \n 2) for \n 3) do while \nВыберите число: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (y == 0)
                        {
                            z = 0;
                            Console.WriteLine($"z = {z}\n");
                        }
                        else if ((y > 0) & (y < 1.36))
                        {
                            dy = 0.136;
                            while (y < 1.36)
                            {
                                z = (1 / (v + y));
                                y += dy;
                                Console.WriteLine($"z = {z}\n");
                            }
                        }
                        else if (y > -1.5 && y < 0)
                        {
                            dy = 0.15;
                            while (y < 0)
                            {
                                z = (1 / (v - 2 * y));
                                y += dy;
                                Console.WriteLine($"z = {z}\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Не определен\n");
                        }
                        break;
                    
                    
                    case "2":
                        if (y == 0)
                        {
                            z = 0;
                            Console.WriteLine($"z = {z}\n");
                        }
                        else if ((y > 0) & (y < 1.36))
                        {
                            dy = 0.136;
                            for(double i = y; y < 1.36; y += dy)
                            {
                                z = (1 / (v + y));
                                //y += dy;
                                Console.WriteLine($"z = {z}\n");
                            }
                        }
                        else if (y > -1.5 && y < 0)
                        {
                            dy = 0.15;
                            for(double i = y; y < 0; y += dy)
                            {
                                z = (1 / (v - 2 * y));
                                //y += dy;
                                Console.WriteLine($"z = {z}\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Не определен\n");
                        }
                        break;
                                        
                    case "3":
                        if (y == 0)
                        {
                            z = 0;
                            Console.WriteLine($"z = {z}\n");
                        }
                        else if ((y > 0) & (y < 1.36))
                        {
                            dy = 0.136;
                            do
                            {
                                z = (1 / (v + y));
                                y += dy;
                                Console.WriteLine($"z = {z}\n");
                            } while (y <= 1.36);
                        }
                        else if (y > -1.5 && y < 0)
                        {
                            dy = 0.15;
                            /*for (double i = y; y < 0; y += dy)
                            {
                                z = (1 / (v - 2 * y));
                                //y += dy;
                                Console.WriteLine($"z = {z}\n");
                            }*/
                            do
                            {
                                z = (1 / (v - 2 * y));
                                y += dy;
                                Console.WriteLine($"z = {z}\n");
                            } while (y <= 0);
                        }
                        else
                        {
                            Console.WriteLine("Не определен\n");
                        }
                        break;

                }
                Console.Write("Продолжить?[y/n]: ");
                choice = Console.ReadLine();
            } while (choice != "n");



        }
    }
}