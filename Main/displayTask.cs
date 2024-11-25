using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class displayTask
    {

        static List<string> taskList = new List<string>();

        public static void DisplayTask()
        {
            Console.Clear();
            Console.WriteLine("=== Lista Zadań ===");

            if (taskList.Count == 0)
            {
                Console.WriteLine("Brak zadań na liście.");
            }
            else
            {
                for (int i = 0; i < taskList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {taskList[i]}");
                }
            }

        }

        public static void AddTask()
        {
            Console.Clear();
            Console.WriteLine("=== Dodaj zadanie ===");

            Console.Write("Wpisz opis zadania: ");
            string description = Console.ReadLine();

            Console.Write("Podaj date i godzinę wykonania zadania (yyyy-mm-dd hh:mm): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dueDate))
            {
                taskList.Add(description);
                Console.WriteLine("Dodano nowe zadanie!");

            }
            else
            {
                Console.WriteLine("Nieprawidłowa data. Spróbuj jeszcze raz.");
            }

        }

        internal static void RemoveTask()
        {
            throw new NotImplementedException();
        }
    }
}
