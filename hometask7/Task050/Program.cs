Console.Clear();
Console.WriteLine("Введите размер массива");
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());
double[,] matrix = new double[a,b];
int row = 0, column = 0;
for(row = 0; row<a; row++)
{
    for(column = 0; column<b;column++)
    {
        matrix[row,column] = new Random().NextDouble();
        Console.Write($"{matrix[row,column] };;");
    }
   Console.WriteLine(); 
}
Console.WriteLine("Введите позицию элемента");
Console.Write("a_num = ");
int a_check = int.Parse(Console.ReadLine());
Console.Write("b_num = ");
int b_check = int.Parse(Console.ReadLine());
if(a_check < a)
{
    if(b_check < b)
    {
        Console.Write($"Искомый элемент = {matrix[a_check,b_check] }");
    }
    else Console.WriteLine("Такого элемента нет");
}
else Console.WriteLine("Такого элемента нет");
