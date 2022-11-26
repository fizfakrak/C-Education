Console.Clear();
int length = 0;
int index = 0;

length = new Random().Next(3,101);
Console.WriteLine($"Длина генерируемого массива: {length}");
int[] array = new int[length];

for(index = 0; index<length; index++)
{
    array[index] = new Random().Next(1,101);
   // Console.WriteLine($"{array[index]} ");
}

index = new Random().Next(3,length);
array[index] = 0;
Console.WriteLine();
Console.WriteLine($"Индекс принудительного занесенного нуля в массив: {index}");
index = 0;
Console.WriteLine("Элементы сгенерированного массива: ");
for(index = 0; index<length; index++)
{
  //  array[index] = new Random().Next(1,101);
    Console.Write($"{array[index]} ");
}

    int max1 = 0;
    int max2 = 0;

if (array[0]>=array[1]) 
{
    max1 = array[0];
    max2 = array[1];
}
else
{
    max2 = array[0];
    max1 = array[1];
}

index = 1;

while(array[index] > 0)
{
    if(array[index]>max1)
    {
        max2 = max1;
        max1 = array[index];
    }
    else if(array[index] == max1)
    {
        
    }
    else if(array[index] > max2)
    {
        max2 = array[index];
    }
    index++;
}

Console.Write($"Ответ: {max2}");