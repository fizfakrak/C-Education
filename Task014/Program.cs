Console.Clear();
Console.Write("Введите число: ");
int input_number = int.Parse(Console.ReadLine());
if(input_number % 7 == 0 && input_number % 23 == 0)Console.Write("Число кратно 7 и 23");
else Console.Write("Число некратно 7 и/или 23");