// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Найдем координаты (x; y) точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите число b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = double.Parse(Console.ReadLine());

if (k1 == 0 || k2 == 0)
{
    Console.WriteLine("k1 и k2 не должны быть равны 0");
    return;
}
if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают");
    return;
}
else if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
    return;
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Прямые пересекаются в точке ({x:f1}; {y:f1})");
}