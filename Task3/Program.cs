using System;
using System.Text;

 namespace Task3
{
    public class Program
    {


        public static string ClassifyAge(int age)
        {
            if (age < 0 || age > 120)
            {
                return ("Нереальний вік");
            }
            else if (age < 12)
            {
                return "Ви дитина";
            }
            else if (age < 18)
            {
                return "Підліток";
            }
            else if (age < 60)
            {
                return "Дорослий";
            }
            else
            {
                return "Пенсіонер";
            }

        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Будь ласка, введіть ваш вік:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                string category = ClassifyAge(age);
                Console.WriteLine(category);
            }
            else
            {
                Console.WriteLine("Некоректне введення. Будь ласка, введіть ціле число.");
            }
        }
    }
}
