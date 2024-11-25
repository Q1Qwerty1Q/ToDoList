using Main;
using System.Diagnostics;

internal class Program
{

   
    

    private static void Main(string[] args)
    {

        bool running = true;

        while(running)
        {
            Console.Clear();
            Console.WriteLine("=== Lista Zadań ===");
            Console.WriteLine("=== 1. Wyświetl zadania ===");
            Console.WriteLine("=== 2. Dodaj zadanie ===");
            Console.WriteLine("=== 3. Usuń zadanie ===");
            Console.WriteLine("=== 4. Wyjdź ===");



        }

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                displayTask.DisplayTask();
                break;
            case "2":
                displayTask.AddTask();
                break;
            case "3":
                displayTask.RemoveTask();
                break;
            case "4":
                running = false;
                break;
            default:
                Console.WriteLine("Nieprawidłowa opcja, spróbuj jeszcze raz.");
                Console.ReadKey();
                break;
        }
    }

    

    
   

  


   

}