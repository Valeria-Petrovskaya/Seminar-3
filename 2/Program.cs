Console.Clear();
Console.WriteLine("Координата точки 1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Координата точки 2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.Write($"Расстояние между точками: {Math.Round (result, 3)}");

