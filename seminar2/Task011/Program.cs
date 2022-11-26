Console.Clear();
int input_number = new Random().Next(100,1000);
int output_number = input_number/100*10 + input_number%10;
Console.WriteLine($"Случайное число: {input_number}");
Console.Write($"Вывод: {output_number}");