Console.Clear();
Console.Write("Введите координату х: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите координату y: ");
double y = double.Parse(Console.ReadLine());

if(x > 0 && y > 0)
    Console.Write("1");
else if(x < 0 && y > 0)
    Console.Write("2");
else if(x > 0 && y < 0)
    Console.Write("3");
else if(x < 0 && y < 0)
    Console.Write("4");