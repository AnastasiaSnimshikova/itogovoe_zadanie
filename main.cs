
using System;

class Program
{
    static void Main()
    {
        // Ввод исходного массива строк
        Console.WriteLine("Введите элементы массива через пробел:");
        string[] inputArray = Console.ReadLine().Split(' ');

        // Создание нового массива для строк длиной не более 3 символов
        string[] newArray = new string[inputArray.Length];
        int index = 0;

        // Перебор исходного массива и проверка длины каждой строки
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                newArray[index] = str; // Запись строки в новый массив
                index++;
            }
        }

        // Вывод нового массива строк длиной не более 3 символов
        Console.WriteLine("Новый массив строк длиной не более 3 символов:");
        for (int i = 0; i < index; i++)
        {
            Console.Write(newArray[i] + " ");
        }
    }
}