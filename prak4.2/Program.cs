using System;

namespace prak4_2
{
    class Program
    {
        static void Main()
        {
            List<int> sub_list = new List<int>();
            LinkedList<int> main_list = new LinkedList<int>();

            while (true)
            {
                Console.WriteLine("Выберите дейстивие:");
                Console.WriteLine("1 - Создать список");
                Console.WriteLine("2 - Добавить элемент в список(2)");
                Console.WriteLine("3 - Удалить элемент из списка");
                Console.WriteLine("4 - Вывести список");
                Console.WriteLine("5 - Уничтожить список");
                Console.WriteLine("6 - Выйти");

                Console.Write("Действие: ");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Количество элементов в списке: ");
                        int listLen = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= listLen; i++)
                        {
                            Console.Write($"\n{i} элемент ");
                            sub_list.Add(Convert.ToInt32(Console.ReadLine()));
                        }

                        main_list = new LinkedList<int>(sub_list);
                        Console.WriteLine("\nСоздан новый список");
                        break;
                    case 2:
                        Console.WriteLine("1 - Добавить элемент в произвольное место");
                        Console.WriteLine("2 - Добавить элемент в конец списка");
                        Console.Write("Действие: ");

                        int inChoice = Convert.ToInt32(Console.ReadLine());
                        switch (inChoice)
                        {
                            case 1:
                                Console.Write("Новое значение: ");
                                int new_data = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Позиция: ");
                                int pos = Convert.ToInt32(Console.ReadLine());
                                break;
                        }

                        break;
                    case 4:
                        foreach (var i in main_list)
                        {
                            Console.Write($"{i}");
                        }

                        Console.WriteLine();
                        break;
                    case 5:
                        main_list.Clear();
                        Console.WriteLine("Список обнулен");
                        break;
                    case 6:
                        return;
                }
            }
        }
    }
}