using System;

namespace Lab04Variant3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторна робота №4, Варiант 3");

            // Завдання 1: Робота з одновимірним масивом
            Console.WriteLine("\n--- Завдання 1 ---");

            // Створюємо масив дійсних чисел
            double[] array = { 5.7, -2.3, 8.1, -4.5, 1.2, -6.8, 3.0, 10.5, -1.9 };

            // Виводимо початковий масив
            Console.WriteLine("Початковий масив:");
            PrintArray(array);

            // а) Обчислюємо добуток від'ємних елементів масиву
            double negativeProduct = CalculateNegativeProduct(array);
            Console.WriteLine($"\nа) Добуток вiд'ємних елементiв масиву: {negativeProduct}");

            // б) Обчислюємо суму додатних елементів масиву до максимального
            double sumPositiveBeforeMax = CalculateSumOfPositiveBeforeMax(array);
            Console.WriteLine($"б) Сума додатних елементiв до максимального: {sumPositiveBeforeMax}");

            // Змінюємо порядок елементів масиву на протилежний
            ReverseArray(array);
            Console.WriteLine("\nМасив пiсля зміни порядку елементiв:");
            PrintArray(array);

            // Завдання 2: Робота з двовимірним масивом
            Console.WriteLine("\n\n--- Завдання 2 ---");

            // Створюємо двовимірний масив
            double[,] matrix = {
                { 1.1, 2.2, 3.3, 4.4 },
                { 5.5, 6.6, 7.7, 8.8 },
                { 9.9, 10.0, 11.1, 12.2 }
            };

            // а) Виводимо увесь масив на екран
            Console.WriteLine("а) Виведення всього масиву:");
            PrintMatrix(matrix);

            // б) Виводимо елемент другого рядку масиву (індекс 1)
            int secondRowElementIndex = 2; // Виберемо третій елемент (індекс 2) у другому рядку
            Console.WriteLine($"\nб) Елемент другого рядку з iндексом {secondRowElementIndex}: {matrix[1, secondRowElementIndex]}");

            // в) Виводимо будь-який елемент масиву
            int anyRowIndex = 2;
            int anyColIndex = 1;
            Console.WriteLine($"в) Елемент масиву [рядок {anyRowIndex}, стовпець {anyColIndex}]: {matrix[anyRowIndex, anyColIndex]}");

            Console.ReadLine();
        }

        // Метод для виведення одновимірного масиву
        static void PrintArray(double[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        // а) Метод для обчислення добутку від'ємних елементів масиву
        static double CalculateNegativeProduct(double[] arr)
        {
            double product = 1.0; // Початкове значення для добутку
            bool hasNegative = false; // Прапорець для перевірки, чи є від'ємні елементи

            foreach (var item in arr)
            {
                if (item < 0)
                {
                    product *= item;
                    hasNegative = true;
                }
            }

            // Якщо немає від'ємних елементів, повертаємо 0
            return hasNegative ? product : 0;
        }

        // б) Метод для обчислення суми додатних елементів до максимального
        static double CalculateSumOfPositiveBeforeMax(double[] arr)
        {
            // Знаходимо максимальний елемент та його індекс
            double maxValue = arr[0];
            int maxIndex = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                    maxIndex = i;
                }
            }

            // Обчислюємо суму додатних елементів до максимального
            double sum = 0;
            for (int i = 0; i < maxIndex; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }

        // Метод для зміни порядку елементів масиву на протилежний
        static void ReverseArray(double[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                // Обмін елементів
                double temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                // Зсуваємо покажчики
                left++;
                right--;
            }
        }

        // Метод для виведення двовимірного масиву
        static void PrintMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}