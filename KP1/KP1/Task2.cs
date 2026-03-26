using System;
using System.IO;

namespace ModularWork
{
   
    public class MessagePublisher
    {
        public event Action<string> OnMessageSent; // event для повідомлення [cite: 22]

        [cite_start]
        public void Send(string message) // метод викликає event [cite: 23]
        {
            OnMessageSent?.Invoke(message);
        }
    }

    [cite_start]// Клас для запису у файл [cite: 24]
    public class FileLogger
    {
        private string _path;
        public FileLogger(string path) => _path = path;

        public void Subscribe(MessagePublisher pub) => pub.OnMessageSent += Log; // підписка на event [cite: 25]

        private void Log(string msg)
        {
            [cite_start]// Формат запису: [час] повідомлення [cite: 27]
            string entry = $"[{DateTime.Now:HH:mm:ss}] {msg}";
            File.AppendAllLines(_path, new[] { entry }); // запис у файл logPD24.txt [cite: 19, 26]
        }
    }

    public class Task2
    {
        public static void Execute()
        {
            var pub = new MessagePublisher();
            var logger = new FileLogger("logPD24.txt");
            logger.Subscribe(pub);

            Console.WriteLine("\nЗавдання 2: Введіть текст 4 рази:");
            [cite_start] for (int i = 1; i <= 4; i++) // Користувач вводить текст 4 рази [cite: 18]
            {
                Console.Write($"{i}: ");
                string input = Console.ReadLine();
                pub.Send(input);
            }
        }
    }
}