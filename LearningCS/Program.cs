//Работа с матрицами

Console.WriteLine("\tРабота с матрицами.");
Console.WriteLine("--------------------------------------\n");

int n;
do
{
    Console.Write("Введите размерность матриц: ");
    n = Convert.ToInt32(Console.ReadLine());

    if ((n == 0) || (n < 0)) Console.WriteLine("Размерность матрицы не может быть 0 либо отрицательной. Осуществите повторный ввод");

} while ((n == 0) || (n < 0));

Console.WriteLine($"\nСоздаем матрицу A размерности {n}\n");

int[,] arr1 = new int[n, n];

FillRand(arr1, n);
Print(arr1, n);
Console.WriteLine();

Console.WriteLine($"\nСоздаем матрицу B размерности {n}\n");

int[,] arr2 = new int[n, n];

FillRand(arr2, n);
Print(arr2, n);
Console.WriteLine();

Console.WriteLine("--------------------------------------\n");

Console.WriteLine($"Результат сложения матриц А и В:\n");

int[,] arr3 = new int[n, n];

SumArray(arr1, arr2, arr3, n);
Print(arr3, n);
Console.WriteLine();

void FillRand(int[,] arr, int n)
{
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rnd.Next(-50, 50);
        }
    }
}

void Print(int[,] arr, int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void SumArray(int[,] arr1, int[,] arr2, int[,] newArr, int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArr[i, j] = arr1[i, j] + arr2[i, j];
        }
    }
}