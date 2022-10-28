// Задача 58: Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void Zadacha58()
{
    int n = 4;
    int[,] numbers = new int[n, n];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= numbers.GetLength(0) * numbers.GetLength(1))
    {
        numbers[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < numbers.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= numbers.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > numbers.GetLength(1) - 1)
            j--;
        else
            i--;
    }
     PrintArray(numbers);
}

   

    void PrintArray(int[,] numbers)
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                if (numbers[i, j] / 10 <= 0)
                    Console.Write($" {numbers[i, j]} ");

                else Console.Write($"{numbers[i, j]} ");
            }
            Console.WriteLine();
        }
    }

Zadacha58();