// Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

Main();

void Main()
{
    Console.Write("Введите начальное значение диапазона: ");
    int M = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите конечное значение диапазона: ");
    int N = Convert.ToInt32(Console.ReadLine());

    if (M > N)
    {
        System.Console.WriteLine("Начальное значение не должно первышать конечное!");
        return;
    }
    else
    {
        PrintNumbers(M+1,N);
    }
}

void PrintNumbers(int startPosition, int endPosition)
{
    if(startPosition >= endPosition) return;
    System.Console.Write(startPosition + " ");
    PrintNumbers(startPosition + 1, endPosition);
}