/*Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] array = new int[4, 4];
int temp = 1;
int i = 0;
int j = 0;

void WriteArray(int[,] array)
    {
    for(int i = 0;i < 4;i++)
        {
        for(int j = 0;j < 4;j++)
            {
            if(array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");
            else
                Console.Write($"{array[i, j]} ");
            }
        Console.WriteLine();
        }
    }

while(temp <= 4 * 4)
    {
    array[i, j] = temp;
    temp++;
    if(i <= j + 1 && i + j < 3)
        j++;
    else if(i < j && i + j >= 3)
        i++;
    else if(i >= j && i + j > 3)
        j--;
    else
        i--;
    }

WriteArray(array);
Console.ReadKey();
