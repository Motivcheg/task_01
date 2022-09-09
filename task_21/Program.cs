double x1, x2, y1, y2, z1, z2;

Console.WriteLine("Enter x1 coordinate of first point");

x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter y1 coordinate of first point");

y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter z1 coordinate of first point");

z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter x2 coordinate of first point");

x2 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter y2 coordinate of second point");

y2 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter z2 coordinate of second point");

z2 = double.Parse(Console.ReadLine());


double result = Math.Pow((Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)*1.0), 0.5);

Console.WriteLine(result);