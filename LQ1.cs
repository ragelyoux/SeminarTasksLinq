//LQ1.Используя Linq, циклически сдвинуть массив на K влево. Без циклов. Без Reverse.

using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Введите количество сдвигов: ");
        int k = int.Parse(Console.ReadLine());
        int[] shiftedArray = ShiftArrayLeft(array, k);

        Console.WriteLine($"Сдвиг на: {k}");
        Console.WriteLine(string.Join(", ", shiftedArray));
    }
    static int[] ShiftArrayLeft(int[] array, int k)
    {
        int n = array.Length;
        // Корректируем k так, чтобы оно находилось в диапазоне длины массива
        k = k % n;
        // Используем Skip(k) для пропуска первых k элементов массива и Concat с Take для добавления первых k элементов в конец.
        // Результат записываем в массив с помощью ToArray().
        var shiftedArray = array.Skip(k).Concat(array.Take(k)).ToArray();
        return shiftedArray;
    }
}