// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

float GetСoordinatesX(float k1, float b1, float k2, float b2)
{
    float x = (b2 - b1) / (k1 - k2);                                                                     //k1*x+b1-k2*x-b2=x*(k1-k2)+b1-b2=0 x=(b2-b1)/(k1-k2)
    return x;
}

float GetСoordinatesY(float x, float k2, float b2)
{
    float y = (k2 * x + b2);
    return y;
}

void main()
{
    System.Console.WriteLine("Введите k1:");
    float k1 = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine("Введите b1:");
    float b1 = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine("Введите k2:");
    float k2 = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine("Введите b2:");
    float b2 = int.Parse(Console.ReadLine()!);

    if ((k1 == k2) && (b1 != b2)) Console.WriteLine("Прямые параллельны");
    else if ((k1 == k2) && (b1 == b2)) Console.WriteLine("Прямые совпадают");
    else
    {
        float x = GetСoordinatesX(k1, b1, k2, b2);
        float y = GetСoordinatesY(x, k2, b2);
        Console.WriteLine($"прямые пересекаются в координатах ({x};{y})");
    }
}

main();