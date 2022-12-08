Console.Clear();
Console.Write("Введитее число: ");
int input_number1 = int.Parse(Console.ReadLine());
int result = 0;
while(input_number1 > 0)
{
    result += input_number1%10;
    input_number1 = input_number1/10;
}
Console.Write($"Результат: {result}");