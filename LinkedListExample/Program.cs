using System;

namespace prak4_2
{
    class Program
    {
        static void Main()
        {
            DoublyLinkedList list = null;
            
            while (true)
            {
                Console.WriteLine("Выберите действие");
                Console.WriteLine("1 - Создать список");
                Console.WriteLine("2 - Добавить в конец списка");
                Console.WriteLine("3 - Добавить в произвольное место");
                Console.WriteLine("4 - Удалить элемент из списка");
                Console.WriteLine("5 - Вывести список(2)");
                Console.WriteLine("6 - Уничтожить список");
                Console.WriteLine("7 - Выйти");
                
                Console.Write("Действие: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        list = new DoublyLinkedList();
                        list.AddElementsFromInput();
                        Console.WriteLine("Список создан");
                        break;
                    case 2:
                        Console.Write("Новые данные: ");
                        int data = Convert.ToInt32(Console.ReadLine());
                        list.AddToEnd(data);
                        break;
                    case 3:
                        Console.Write("Новые данные: ");
                        int insertData = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Позиция: ");
                        int position = Convert.ToInt32(Console.ReadLine());
                        list.InsertAt(insertData, position);
                        break;
                    case 4:
                        Console.Write("Позиция: ");
                        int deletePosition = Convert.ToInt32(Console.ReadLine());
                        list.Delete(deletePosition);
                        break;
                    case 5:
                        Console.WriteLine("1 - Вывести весь список");
                        Console.WriteLine("2 - Вывести элемент по индексу");
                        
                        Console.Write("Действие: ");
                        int inChoice5 = Convert.ToInt32(Console.ReadLine());
                        switch (inChoice5)
                        {
                            case 1:
                                list.ReadAll();
                                break;
                            case 2:
                                Console.Write("Индекс: ");
                                int w = Convert.ToInt32(Console.ReadLine());
                                list.ReadAtIndex(w);
                                break;
                        }
                        break;
                    case 6:
                        list = null;
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Нет такого выбора");
                        break;
                }
            } 
        }
    }

    class Node
    {
        public int data;
        public Node prev;
        public Node next;
    }

    class DoublyLinkedList
    {
        private Node head;
        
        
        public void AddElementsFromInput()
        {
            Console.Write("Введите количество элементов: ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write("\nВведите значение элемента: ");
                int value = Convert.ToInt32(Console.ReadLine());
                Node newNode = new Node(); 
                newNode.data = value; 
                newNode.next = null; 
                if (head == null) 
                {
                    newNode.prev = null;
                    head = newNode;
                }
                else 
                {
                    Node lastNode = head;
                    while (lastNode.next != null)
                    {
                        lastNode = lastNode.next;
                    }

                    lastNode.next = newNode;
                    newNode.prev = lastNode;
                }
            }
        }

        
        
        public void AddToEnd(int data)
        {
            Node newNode = new Node();
            newNode.data = data;

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node lastNode = head;
                while (lastNode.next != null) 
                {
                    lastNode = lastNode.next;
                }
                lastNode.next = newNode; 
                newNode.prev = lastNode; 
            }
        }

        public void InsertAt(int data, int position)
        {
            Node newNode = new Node();
            newNode.data = data;

            if (position == 1)
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }
            else
            {
                Node temp = head;
                for (int i = 1; i < position; i++)
                {
                    temp = temp.next;
                }

                newNode.next = temp.next;
                temp.next.prev = newNode;
                temp.next = newNode;
                newNode.prev = temp;
            }
        }

        public void Delete(int position)
        {
            if (position == 1)
            {
                head = head.next;
                if (head != null)
                {
                    head.prev = null;
                }
            }
            else
            {
                Node temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    temp = temp.next;
                }
                if (temp.next != null)
                {
                    temp.next = temp.next.next;
                    if (temp.next != null)
                    {
                        temp.next.prev = temp;
                    }
                }
            }
        }

        public void ReadAll()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
        
        public void ReadAtIndex(int index)
        {
            Node current = head;
            for (int i = 1; i < index; i++)
            {
                if (current == null)
                {
                    Console.WriteLine("Нет элемента по индексу");
                    return;
                }
                current = current.next;
            }
            if (current != null)
            {
                Console.WriteLine("Элемент: " + current.data);
            }
            else
            {
                Console.WriteLine("Нет элемента по индексу");
            }
        }

    }
}