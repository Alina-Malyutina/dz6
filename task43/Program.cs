Console.WriteLine("This program assepts coefficient k and b for two functions y = kx + b type and print intersection point");
Console.Write("Enter k for first functoin: ");
double k1 = Convert.ToInt64(Console.ReadLine());

Console.Write("Enter b for first functoin: ");
double b1 = Convert.ToInt64(Console.ReadLine());

Console.Write("Enter k for second functoin: ");
double k2 = Convert.ToInt64(Console.ReadLine());

Console.Write("Enter b for second functoin: ");
double b2 = Convert.ToInt64(Console.ReadLine());

double SearchCommonX (double K1, double K2, double B1, double B2)
{
    double X = (B2 - B1) / (K1-K2);
    return X;
}

double SearchCommonY (double Ko1, double Bo1, double X)
{
    double Y = Ko1 * X + Bo1;
    return Y;
}

double x = SearchCommonX(k1, k2, b1, b2);
double y = SearchCommonY(k1,k2,x);

Console.WriteLine($"Intersection point for y = {k1}x + {b1} and y = {k2}x + {b2} is [{x};{y}]");
