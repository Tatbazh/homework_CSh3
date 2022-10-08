// входные данные - число N
// выводные - таблица кубов чисел от 1 до N
void Cube(int N)
{
    for (int index = 1; index <= N; index++)
    {
        //index = Math.Pow(index, 3);
        Console.Write($"{Math.Pow(index, 3)}   ");
    }
}
Console.Clear();
Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);
Cube(number);