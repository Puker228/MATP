using System;
using System.Net.Sockets;

namespace Prak4
{
    class Program
    {
        static void Main()
        {
            List<int> llist = new List<int>();
            int listLen;
            int listNum;
            
            while (true)
            {
                Console.WriteLine("Выберите дейстивие:");
                Console.WriteLine("1 - Создать список");
                Console.WriteLine("2 - Вставить элемент в список");
                Console.WriteLine("3 - Удалить элемент из списка");
                Console.WriteLine("4 - Вывести список");
                Console.WriteLine("5 - Уничтожить список");
                Console.WriteLine("6 - Выйти");


                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Количество элементов в списке: ");
                        listLen = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= listLen; i++)
                        {
                            Console.Write($"\n{i} элемент: ");
                            llist.Add(Convert.ToInt32(Console.ReadLine()));
                        }
                        Console.WriteLine("\nСоздан новый список\n");
                        break;
                    case "2":
                        Console.WriteLine("Какой элемент вы хотите заменить?");
                        listNum = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Число:");
                        llist[listNum] = Convert.ToInt32(Console.ReadLine());
                        
                        break;
                    case "4" :
                        foreach (var i in llist)
                        {
                            Console.Write($"{i} ");
                        }
                        Console.WriteLine();
                        break;
                    case "5":
                        llist.Clear();
                        Console.WriteLine("\nСписок взорван\n");
                        break;
                    case "6":
                        return;
                }
            }
        }
    }
}