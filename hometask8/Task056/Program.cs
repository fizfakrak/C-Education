Console.Clear();
Console.WriteLine("Введите сторону квадратного массива");
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
int[,] matrix = new int[a,a];
int row = 0, column = 0;
Console.WriteLine("Исходный массив");
for(row = 0; row<a; row++)
{
    for(column = 0; column<a;column++)
    {
        matrix[row,column] = new Random().Next(0,10);
        Console.Write($"{matrix[row,column]}    ");
    }
   Console.WriteLine(); 
}

int min_row = 0,sum = 0,min_index = 0;
row = 0;
for(column = 0; column<a;column++)
{
    sum = sum + matrix[row,column];
}
    min_row = sum;
    sum = 0;
for(row = 1; row<a; row++)
{
    for(column = 0; column<a;column++)
    {
        sum = sum + matrix[row,column];
    }
    if(sum < min_row)
    {
        min_row = sum;
        min_index = row;
    }
    sum = 0;
}
Console.WriteLine($"Индекс строки с минимальной суммой элементов = {min_index}");