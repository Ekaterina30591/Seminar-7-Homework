/*
//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
double[,] CreateRandom2DArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a minimum possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a maximum possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), 2);
        }
    }
    return array;
}

void Show2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
            
            Console.WriteLine();
        }
    }
}

double[,] my2DArray = CreateRandom2DArray();
Show2DArray(my2DArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2DArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a minimum possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a maximum possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");

            Console.WriteLine();
        }
    }
}

void ElementPosition(int[,] array)
{
    Console.WriteLine("Input row number of the element: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input column number of the element: ");
    int column = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (row < array.GetLength(0) || column < array.GetLength(1))
            {
               Console.WriteLine ($"The element in row {row} and column {column} is equal to {array[row-1,column-1]}");
            }
            else
            {
                Console.WriteLine("The element does not exist in the array");
            }
        }
    }
}

int[,] my2DArray = CreateRandom2DArray();
Show2DArray(my2DArray);
ElementPosition(my2DArray);