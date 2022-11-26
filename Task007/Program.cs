Console.Clear();
Console.Write("Введите трехзначное число: ");
int input_number = int.Parse(Console.ReadLine());
Console.Write("Число в разряде единиц: ");
Console.Write(input_number % 10);