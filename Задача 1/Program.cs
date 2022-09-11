int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2> result) result = arg2;
    if(arg3> result) result = arg3;
    return result;
}
int a1 = 14;
int b1 = 26;
int c1 = 33;
int a2 = 81;
int b2 = 27;
int c2 = 54;
int a3 = 97;
int b3 = 21;
int c3 = 67;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
Console.Write("max = ");
Console.Write(max);