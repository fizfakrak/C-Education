Console.Clear();
int a = 4;
int[,] matrix_1 = new int[a,a];
int row = 0, column = 0;
int number = 1;


for(column = 0; column<a;column++)
{
    matrix_1[0,column] = number++;
}
for(row = 1; row<a; row++)
{
    matrix_1[row,a-1] = number++;
}
for(column = a-2; column >= 0;column--)
{
    matrix_1[a-1,column] = number++;
}
for(row = a-2; row >= 1; row--)
{
    matrix_1[row,0] = number++;
}
for(column = 1; column<a-1;column++)
{
    matrix_1[1,column] = number++;
}
for(column = 2; column>= 1;column--)
{
    matrix_1[2,column] = number++;
}

Console.WriteLine("Результат");

for(row = 0; row<a; row++)
{
    for(column = 0; column<a;column++)
    {
        Console.Write($"{matrix_1[row,column]}    ");
    }
   Console.WriteLine(); 
}