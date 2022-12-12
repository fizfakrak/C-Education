Console.Clear();
void FillArray(double[] collection)
{
int length = collection.Length; 
int index = 0;
while(index < length)
    {
        collection[index] = new Random().NextDouble();
        index++;
    } 

}
double[] array = new double[10];
double max = 0, min = 0;
FillArray(array);
if (array[0]>array[1]) 
{
    max = array[0];
    min = array[1];
}
else { 
        max = array[1];
        min = array[0];
     }
int counter = 0;
for(counter = 2; counter <array.Length; counter++)
{
    if(array[counter]> max) max = array[counter];
    else if (array[counter]< min) min = array[counter];
}
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Max = {max}, Min = {min}");