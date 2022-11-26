Console.Clear();
Console.Write("Введите первое число ");
int input_number_1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int input_number_2 = int.Parse(Console.ReadLine());
if(input_number_1 / input_number_2 == input_number_2 || input_number_2 / input_number_1 == input_number_1)Console.Write("yes");
else Console.Write("no");