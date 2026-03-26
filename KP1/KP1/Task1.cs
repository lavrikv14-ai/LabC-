ususing System;
using System.IO;

namespace ModularWork
{
    [cite_start]// Створення делегата для операцій над текстом [cite: 6]
    public delegate string TextOperation(string input);

    public class Task1
    {
        [cite_start]// Метод, який читає файл, виконує операцію та дописує результат [cite: 10, 12, 13, 14]
        public static void ProcessFile(string inputFile, string outputFile, TextOperation operation)
        {
            if (File.Exists(inputFile))
            {
                string text = File.ReadAllText(inputFile);
                string result = operation(text);
                File.AppendAllText(outputFile, result + Environment.NewLine + "---" + Environment.NewLine);
            }
        }

        public static void Execute()
        {
            string input = "textPD24.txt"; // [cite: 4, 28]
            string output = "resultPD24.txt"; // [cite: 4, 16]

            if (File.Exists(output)) File.Delete(output);

            [cite_start]// Викликаємо метод 3 рази з різними операціями [cite: 15]
            ProcessFile(input, output, s => s.ToUpper()); // UPPERCASE [cite: 7]
            ProcessFile(input, output, s => $"Символів: {s.Length}"); // Кількість символів [cite: 8]
            ProcessFile(input, output, s => $"Слів: {s.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length}"); // Кількість слів [cite: 9]

            Console.WriteLine("Завдання 1 завершено.");
        }
    }
}