Console.Clear();
Console.Write("Введите число: ");
int input_number = int.Parse(Console.ReadLine());
if(input_number%2 == 0) Console.Write("Число четное");
else Console.Write("Число нечетное");