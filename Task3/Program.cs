// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

Main();

void Main()
{
    int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    PrintArray(myArray);
}

void PrintArray(int[] array, int i = 0)
{
    if (i >= array.Length) return;
    PrintArray(array, i+1);
    Console.Write(array[i] + "\t");    
}