// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] GetArray()
{
    System.Console.WriteLine("Введите количество значений массива:");
    int size = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine("Введите минимальное значение массива:");
    int minValue = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine("Введите максимальное значение массива:");
    int maxValue = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int findNumbers(int[] numbers)
{
    int count = 0;
    foreach (int number in numbers)
    {
        if (number > 0)
            count++;
    }
    return count;
}

void main()
{
    Console.Clear();
    int[] numbers = GetArray();
    System.Console.WriteLine(string.Join(", ", numbers));
    int result = findNumbers(numbers);
    System.Console.WriteLine(string.Join("", result));
}

main();