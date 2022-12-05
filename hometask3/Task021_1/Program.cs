Console.Clear();
Console.Write("Введите координату х1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату y1: ");
double y1= double.Parse(Console.ReadLine());
Console.Write("Введите координату z1: ");
double z1= double.Parse(Console.ReadLine());

Console.Write("Введите координату х2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату z2: ");
double z2= double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+ +Math.Pow(z1-z2,2));
Console.Write($"Расстояние: {result}");