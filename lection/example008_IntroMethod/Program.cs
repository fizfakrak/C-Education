﻿Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 11,
    b1 = 21,
    c1 = 31,
    a2 = 12,
    b2 = 22,
    c2 = 95,
    a3 = 13,
    b3 = 23,
    c3 = 33;


int max  = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));

Console.WriteLine($"Max = {max}");