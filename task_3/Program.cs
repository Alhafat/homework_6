// Задача со звездочкой. Напишите программу, которая реализует обход введенного двумерного массива, 
// начиная с крайнего нижнего левого элемента против часовой стрелки.

// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9

Console.Clear();
// {
//     {1,2,3,},
//     {4,5,6,},
//     {7,8,9}
//  };
int[,] GetArray ()
{
    int[,] matrix = new int[3,3];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]=new Random().Next(-5,5);
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " " + "\t");
        }
        Console.WriteLine();
    }
    return matrix;
}


string printNumbers(int[,] numbers)
{
    string text = "";
    for (int i = 2; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1)-1; j++)
        {
            text += Convert.ToString(numbers[i, j]+" ");
        }
    }
    for (int j = 2; j < numbers.GetLength(1); j++)
    {
        for (int i = 2; i > 0; i--)
        {
            text += Convert.ToString(numbers[i, j]+" ");
        }
    }
    for (int i = 0; i < numbers.GetLength(0)-2; i++)
    {
        for (int j = 2; j >0; j--)
        {
            text += Convert.ToString(numbers[i, j]+" ");
        }
    }
    for (int j = 0; j < numbers.GetLength(1)-2; j++)
    {
        for (int i = 0; i < numbers.GetLength(1)-1; i++)
        {
            text += Convert.ToString(numbers[i, j]+" ");
        }
    }
    text += Convert.ToString(numbers[1, 1]+" ");
    return text;
}


int[,] numbers=GetArray ();
string result=printNumbers(numbers);

Console.WriteLine();
Console.Write(result);