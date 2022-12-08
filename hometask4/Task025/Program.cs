Console.Clear();
Console.Write("Введитее число: ");
int input_number1 = int.Parse(Console.ReadLine());
Console.Write("Введитее степень: ");
int input_number2 = int.Parse(Console.ReadLine());
int result = 1;
int counter = 1;
for(counter = 1; counter<=input_number2; counter++)
{
    result = result*input_number1;
}
Console.Write($"Результат: {result}");