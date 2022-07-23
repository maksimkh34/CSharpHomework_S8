int GetInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateTDArray(int size1, int size2, int min, int max)
{
    int[,] array = new int[size1, size2];
    Random rand = new Random();
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            array[i, j] = rand.Next(min, max +1);
        }
    }
    return array;
}

void PrintTDArray(int[,] Array)
{
    int size1 = Array.GetLength(0);
    int size2 = Array.GetLength(1);
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            Console.Write(Array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int findminsum(int[,] array)
{
    int[] sums = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) sums[i] += array[i, j];
    }
    int min = sums[0];
    int place = 0;
    for(int i = 0; i < sums.Length; i++) 
    {
        if(min > sums[i]) 
        {
            min = sums[i];
            place = i;
        }
    }
    return place;
    
}

int[,] array = CreateTDArray(GetInt("Enter size 1: "), GetInt("Enter size 2: "), 0, 15);
PrintTDArray(array);
Console.WriteLine($"The smallest sum of elements in line {findminsum(array)+1}.");