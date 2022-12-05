Console.Clear();
Console.Write("Введите пятизначное число: ");
int input_number = int.Parse(Console.ReadLine());
while((input_number<9999) || (input_number>100000))
{
Console.Write("Введите пятизначное число: ");
input_number = int.Parse(Console.ReadLine());
}
if((input_number/10000 == input_number%10) && ((input_number/1000)%10 == (input_number/10)%10))
{
    Console.Write("Число является палиномом");
}
else Console.Write("Число не является палиномом");