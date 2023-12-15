using System;
using System.Net.Sockets;

namespace Prak4_1
{
    class Program
    {
        static void Main()
        {
            List<int> llist = new List<int>();
            int listLen, listNum, listDel;
            
            while (true)
            {
                Console.WriteLine("Выберите дейстивие:");
                Console.WriteLine("1 - Создать список");
                Console.WriteLine("2 - Добавить элемент в список(2)");
                Console.WriteLine("3 - Удалить элемент из списка");
                Console.WriteLine("4 - Вывести список(2)");
                Console.WriteLine("5 - Уничтожить список");
                Console.WriteLine("6 - Выйти");

                Console.Write("Действие: ");
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
                        Console.WriteLine("\nСоздан новый список");
                        break;
                    
                    case "2":
                        Console.WriteLine("1 - Добавить элемент в произвольное место");
                        Console.WriteLine("2 - Добавить элемент в конец списка");
                        Console.Write("Действие: ");
                        
                        string inChoice2 = Console.ReadLine();
                        switch (inChoice2)
                        {
                            case "1":
                                Console.Write("Номер элемента, на которое вы хотите поместить новое значение: ");
                                listNum = Convert.ToInt32(Console.ReadLine()) - 1;
                                Console.Write("Новое значение: ");
                                llist.Insert(listNum, Convert.ToInt32(Console.ReadLine())); 
                                Console.WriteLine("\nСписок изменен");
                                break;
                            case "2":
                                Console.Write("Новое значение: ");
                                listNum= Convert.ToInt32(Console.ReadLine());
                                llist.Add(listNum); 
                                Console.WriteLine("\nСписок изменен");
                                break;
                        }
                        break;
                    
                    case "3":
                        Console.Write("Номер элемента, который вы хотите удалить: ");
                        listDel = Convert.ToInt32(Console.ReadLine()) - 1;
                        llist.RemoveAt(listDel);
                        Console.WriteLine("\nЭлемент удален");
                        break;
                        
                    case "4" :
                        Console.WriteLine("1 - Вывести весь список");
                        Console.WriteLine("2 - Вывести элемент из списка");
                        
                        int inChoice4 = Convert.ToInt32(Console.ReadLine());
                        switch (inChoice4)
                        {
                            case 1:
                                foreach (var i in llist)
                                {
                                    Console.Write($"{i} ");
                                }
                                Console.WriteLine();
                                break;
                            case 2:
                                Console.Write("Индекс элемента: ");
                                listNum = Convert.ToInt32(Console.ReadLine()) - 1;
                                Console.WriteLine($"{llist[listNum]}");
                                break;
                        }
                        break;
                        
                    case "5":
                        llist.Clear();
                        Console.WriteLine("\nСписок обнулен");
                        break;
                    
                    case "6":
                        return;
                }
            }
        }
    }
}