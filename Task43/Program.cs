Console.Clear();
double b1 = Input("Введите коэффициент 1-ой прямой: ");
double k1 = Input("Введите свободный член 1-ой прямой: ");
double b2 = Input("Введите коэффициент 2-ой прямой: ");
double k2 = Input("Введите свободный член 2-ой прямой: ");

double x = (b1 - b2) / (k1 - k2);
double y = k2 * x + b2; 

Console.WriteLine($"({Math.Round(x, 2)}, {Math.Round(y, 2)})");

double Input(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}