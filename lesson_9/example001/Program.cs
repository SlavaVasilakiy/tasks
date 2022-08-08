Console.Write("Введите начальную цифру: ");
int start = 0;
int.TryParse(Console.ReadLine(), out start);

Console.Write("Введите конечную цифру: ");
int n = 0;
int.TryParse(Console.ReadLine(), out n);

string PrintNumbers(int start, int end)
{
    if (start == end)
        return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}

Console.Write(PrintNumbers(start, n));