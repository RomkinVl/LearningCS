//Работа с матрицами

Console.WriteLine("\tРабота с матрицами.");
Console.WriteLine("--------------------------------------\n");

int n;
do
{
    Console.Write("Введите размерность матриц: ");
    n = Convert.ToInt32(Console.ReadLine());

    if (n == 0) Console.WriteLine("Размерность матрицы не может быть 0. Осуществите повторный ввод");

} while (n == 0);

Console.WriteLine($"\nСоздаем матрицу размерности {n}\n");

int[,] arr1 = new int[n, n];

FillRand(arr1, n);
Print(arr1, n);

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