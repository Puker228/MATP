using System;
using System.Net.Sockets;

namespace Prak4
{
    class Program
    {
        static void Main()
        {
            string cont = "yes";
            while (cont != "no")
            {
                Console.WriteLine("Выберите дейстивие:");
                Console.WriteLine("1 - Создать список");
                Console.WriteLine("2 - Вставить элемент в список");
                Console.WriteLine("3 - Удалить элемент из списка");
                Console.WriteLine("4 - Вывести список");
                Console.WriteLine("5 - Уничтожить список");


                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        List<int> llist = new List<int>();
                        Console.WriteLine("Создан новый список\n");
                        break;
                }
                
                
                cont = Console.ReadLine();
            }
        }
    }
}