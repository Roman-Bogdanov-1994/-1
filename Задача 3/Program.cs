int[] array = { 7, 4, 9, 6, 1, 5, 3 };

int n = array.Length;
int find =5;

int i = 0;

while (i < n)
{
    if(array[i] == find)
    {
        Console.WriteLine(i);
        break;
    }
    //i = i + 1;
    i++;
}