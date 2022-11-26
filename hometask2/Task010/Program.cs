Console.Clear();
Console.Write("Введитее трехзначное число: ");
int input_number = int.Parse(Console.ReadLine());
while((input_number > 999)||(input_number < 100))
{
    Console.Write("Введитее трехзначное число: ");
    input_number = int.Parse(Console.ReadLine());
}
input_number = (input_number/10)%10;
Console.Write($"Вторая цифра: {input_number}");