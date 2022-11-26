Console.Clear();
Console.Write("Введите число ");
int counter;
int input_number = int.Parse(Console.ReadLine());
if(input_number>=0)
{
    for(counter = -1*input_number;counter < input_number+1;counter++)
    {
        Console.Write($"{counter} ");
    }
}
else
{
       for(counter = -1*input_number;counter > input_number-1;counter--)
    {
        Console.Write($"{counter} ");
    } 
}