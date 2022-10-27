// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

void Zadacha56()
{
    Random random = new Random();
    int rows = random.Next(4, 6);
    int columns = random.Next(4, 6);
    Console.WriteLine($"Массив размера {rows}*{columns}");
    int[,] numbers = new int[rows, columns];

    FillArray(numbers);
    PrintArray(numbers);

    Console.WriteLine();

    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        int rezult = 0;
        int min = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += numbers[i, j];
        }
        rezult = sum;
       
            
        Console.WriteLine($" Сумма {i + 1} строки = {rezult} ");
        
    }


}


void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0, 11);
        }
    }
}
void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();

    }
}


Zadacha56();