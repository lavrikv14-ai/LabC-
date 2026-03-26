using System;

namespace ModularWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // Виклик першого завдання
            Task1.Execute();

            // Виклик другого завдання
            Task2.Execute();

            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}