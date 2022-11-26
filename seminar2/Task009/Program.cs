Console.Clear();
int input_number = new Random().Next(10,100);
Console.WriteLine(input_number);
if(input_number % 10 > input_number / 10) Console.WriteLine(input_number % 10);
else Console.WriteLine(input_number / 10);