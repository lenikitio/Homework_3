// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

double Distance3D(int a1, int b1, int c1, int a2, int b2, int c2)
{
    double a = Math.Pow(Convert.ToDouble(a2 - a1), 2);
    double b = Math.Pow(Convert.ToDouble(b2 - b1), 2);
    double c = Math.Pow(Convert.ToDouble(c2 - c1), 2);

    double sqrt = Math.Sqrt(a + b + c);

    return Math.Round(sqrt, 3);
;
}

Console.WriteLine("Введите координаты x, y и z для первой вершины отрезка");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты x, y и z для второй вершины отрезка");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Координаты первой вершиный {x1}, {y1}, {z1}, координаты второй вершины {x2}, {y2}, {z2}");

double distance = Distance3D(x1, y1, z1, x2, y2, z2);
Console.WriteLine ($"Расстояние от двух заданных вершин равно {distance}");



