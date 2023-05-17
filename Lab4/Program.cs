using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Відкриваємо файл
        string filename = "C:\\Users\\Дмитро\\Desktop\\filmlib\\code\\Lab_1_oop\\Lab4\\text.txt";
        string text = File.ReadAllText(filename);

        // Перетворюємо текст у масив символів
        char[] chars = text.ToCharArray();

        // Обчислюємо кількість знаків пунктуації
        int count = CountPunctuationMarks(chars);

        Console.WriteLine($"Кількість знаків пунктуації: {count}");
    }

    static int CountPunctuationMarks(char[] chars)
    {
        // Створюємо колекцію List для зберігання знаків пунктуації
        List<char> punctuationMarks = new List<char>() { '.', ',', ';', ':', '!', '?', '-', '(', ')', '[', ']', '{', '}' };

        // Лічильник кількості знаків пунктуації
        int count = 0;

        // Проходимо по масиву символів та перевіряємо, чи є кожен символ знаком пунктуації
        foreach (char c in chars)
        {
            if (punctuationMarks.Contains(c))
            {
                count++;
            }
        }

        return count;
    }
}
