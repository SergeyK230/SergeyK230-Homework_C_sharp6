void Vvod(int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());   
    }
}

void Print(int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");   
    }
    Console.WriteLine();
}

int Polojit(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        result++;
    }
    return result;
}

int M = 5;
int[] array = new int[M];
Vvod(array);
Print(array);
System.Console.WriteLine(Polojit(array));
