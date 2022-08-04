int n = 4;
int m = 4;
int[,] array = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 1 + i; j < m; j++)
    {
        int tmp = 0;
        tmp = array[i, j];
        array[i, j] = array[j, i];
        array[j, i] = tmp;
    }
}

Console.WriteLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{array[i, j]} ");

    }
    Console.WriteLine();
}
