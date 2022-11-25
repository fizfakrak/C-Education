Console.Clear();
Console.Write("Введите число: ");
int input_number = int.Parse(Console.ReadLine());
int counter;
for(counter = 2;counter < input_number; counter = counter + 2 )
{
Console.Write($"{counter} ");
}