// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Main();

void Main()
{
    Console.Write("Введите значение m: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите значение n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine($"Функция Аккермана при m={m} и n={n} равна {CalculateAkkerman(m, n)}");
}

int CalculateAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return CalculateAkkerman(m - 1, 1);
    else return CalculateAkkerman(m - 1, CalculateAkkerman(m, n - 1));
}