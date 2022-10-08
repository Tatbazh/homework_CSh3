// входные данные - координаты 2-х точек, 
// выводные - расстояние между точками в 3D пространстве
double Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result;
    result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result;
}

Console.Write("Введите координату X точки А: ");
int ax = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y точки А: ");
int ay = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z точки А: ");
int az = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату X точки B: ");
int bx = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y точки B: ");
int by = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z точки B: ");
int bz = int.Parse(Console.ReadLine()!);

Console.Write($"расстояние между точками А и В в 3D пространстве: {Distance(ax,ay,az,bx,by,bz):f2}");