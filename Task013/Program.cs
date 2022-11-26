Console.Clear();
Console.Write("Введитее число: ");
int input_number = int.Parse(Console.ReadLine());
if(input_number < 100) Console.Write($"Третьей цифры нет");
else
{    while (input_number > 1000)
    {
        input_number = input_number/10;
    }
    input_number = input_number % 10;
    Console.Write($"Третья цифра: {input_number}");
}