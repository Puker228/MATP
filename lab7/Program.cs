using System;

namespace lab7
{
    class Program
    {
        static void Main()
        {
            string main_text, new_text;
            
            string cont = "";
            while (cont != "no")
            {
                Console.Write("Текст: ");
                main_text = Console.ReadLine();
                if (main_text.Length < 10)
                {
                    Console.WriteLine("Недостаточно символов");
                }
                else
                {
                    new_text = main_text.Replace("hello", "");
                    string[] tx = new_text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var i in tx)
                    {
                        Console.WriteLine(i);
                    }
                }
                
                Console.WriteLine("\nПовторить?[yes/no]");
                cont = Console.ReadLine();
            }
        }
    }
}