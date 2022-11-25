Console.Clear();
int[] array = {12, 99, 37, 54, 43, 64, 66, 21};
int arrayLength = array.Length;
int find = 64;

int index = 0;

while(index < arrayLength)
{
    if(find == array[index])
    {
        Console.WriteLine($"Index find = {index}");
        break;
    }
    index++;
}