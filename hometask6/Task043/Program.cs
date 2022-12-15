Console.Clear();
double x=0,y=0;
Console.Write($"Введите k1 = ");
double k1 = double.Parse(Console.ReadLine());
Console.Write($"Введите b1 = ");
double b1 = double.Parse(Console.ReadLine());
Console.Write($"Введите k2 = ");
double k2 = double.Parse(Console.ReadLine());
Console.Write($"Введите b2 = ");
double b2 = double.Parse(Console.ReadLine());

x = (b2-b1)/(k1-k2);
y = x*k1+b1;
Console.WriteLine($"x = {x} ");
Console.WriteLine($"y = {y} ");