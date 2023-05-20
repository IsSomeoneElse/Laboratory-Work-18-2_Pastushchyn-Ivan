using System;

namespace LW18_2
{
    class Program
    {
        static void Main()
        {
            int[,] array = {
            { 11, -9, 15 },
            { -26, 2, -16 },
            { 7, 18, 15 },
            { 22, -29, 1 }
        };

            // Перевірка наявності парних чисел у верхньому лівому або нижньому лівому куті
            bool hasEvenNumbers = false;
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            if (array[0, 0] % 2 == 0 || array[rows - 1, 0] % 2 == 0)
            {
                hasEvenNumbers = true;
            }

            Console.WriteLine("Чи є парні числа у верхньому лівому або нижньому лівому куті: " + hasEvenNumbers);

            // Перевірка наявності чисел, що закінчуються нулем, у верхньому правому або нижньому правому куті
            bool hasNumbersEndingWithZero = false;

            if (array[0, columns - 1] % 10 == 0 || array[rows - 1, columns - 1] % 10 == 0)
            {
                hasNumbersEndingWithZero = true;
            }

            Console.WriteLine("Чи є числа, що закінчуються нулем, у верхньому правому або нижньому правому куті: " + hasNumbersEndingWithZero);
        }
    }
}