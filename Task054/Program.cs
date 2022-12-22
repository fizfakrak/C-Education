Console.Clear();
Console.WriteLine("Введите размер массива");
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());
int[,] matrix = new int[a,b];
int row = 0, column = 0;
Console.WriteLine("Исходный массив");
for(row = 0; row<a; row++)
{
    for(column = 0; column<b;column++)
    {
        matrix[row,column] = new Random().Next(0,10);
        Console.Write($"{matrix[row,column]}    ");
    }
   Console.WriteLine(); 
}
Console.WriteLine("Ответ");
int temp = 0,sorted_counter = 0;
for(row = 0; row<a; row++)
{
    for(sorted_counter = 0; sorted_counter<b-1; sorted_counter++)
    {
        for(column = 1; column<(b-sorted_counter);column++)
        {
            if(matrix[row,column-1] > matrix[row,column]) ;
            else
            {
            temp = matrix[row,column-1];
            matrix[row,column-1] = matrix[row,column];
            matrix[row,column] = temp;
            }
        }
    }
}
for(row = 0; row<a; row++)
{
    for(column = 0; column<b;column++)
    {
        Console.Write($"{matrix[row,column]}    ");
    }
   Console.WriteLine(); 
}