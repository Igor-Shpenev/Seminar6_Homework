// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double FindingIntersectionPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;                                                                                    // k1x + b1 = k2x +b2  -> (k1x - k2x) = b2 - b1  -> x = (b2 - b1)  / (k1 - k2); 
}
Console.Write("Input number k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number k2 other than k1: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

if (k1 != k2)
{
    double x = FindingIntersectionPoint(k1, b1, k2, b2);
    double y = k1 * x + b1;
    Console.WriteLine($"The lines intersect at a point x = {x}, y = {y}");
}
else
{
    Console.WriteLine($"The numbers k1 and k2 are equal. Enter different values.");
}
