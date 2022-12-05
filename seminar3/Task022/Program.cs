Console.Clear();
Console.Write("Введите число: ");
int input_number = int.Parse(Console.ReadLine());
int counter = 1;
for(counter = 1; counter<input_number+1;counter++)
{
    Console.Write($"{counter*counter}, ");
}