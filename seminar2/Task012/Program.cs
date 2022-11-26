Console.Clear();
Console.Write("Введите первое число ");
int input_number_1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int input_number_2 = int.Parse(Console.ReadLine());
if(input_number_1%input_number_2 == 0)Console.WriteLine("Кратно");
else Console.WriteLine($"Не кратно, остаток {input_number_1%input_number_2}");