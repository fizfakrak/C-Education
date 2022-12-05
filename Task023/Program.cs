Console.Clear();
Console.Write("Введите число: ");
int input_number = int.Parse(Console.ReadLine());
int counter = 1;
double result = 0;
Console.Write("Список квадратов: ");
while(counter<=input_number)
{
result = Math.Pow(counter, 2);
Console.Write($"{result}, ");
counter++;
}