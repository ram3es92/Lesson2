int n = 10;
int[] arr = {2, 3, 5, 3, 2, 7, 6, 2, 8, 9};
int i = 0;

while (i < arr.Length)
{
    if(arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i = i + 1;
}