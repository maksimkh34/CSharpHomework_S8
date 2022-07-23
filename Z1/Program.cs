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
            array[i, j] = rand.Next(min, max + 1);
        }
    }
    return array;
}

void PrintTDArray(int[,] Array, string text)
{
    int size1 = Array.GetLength(0);
    int size2 = Array.GetLength(1);
    Console.WriteLine(text);
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

void SortArray(int[,] array)
{
    int size1 = array.GetLength(0);
    int size2 = array.GetLength(1);
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2-1; j++)
        {
            int min = array[i, j];
            int temp = 0;
            int minplace = 0;
            bool isminvalplace = true; 
            for (int n = j; n < size2; n++)
            {
                if (array[i, n] < min)
                {
                    min = array[i, n];
                    minplace = n;
                    isminvalplace = false;
                }
            }
            if (isminvalplace == false)
            {
                temp = array[i, j];
                array[i, j] = min;
                array[i, minplace] = temp;
            }
        }
    }
}

int[,] array = CreateTDArray(GetInt("Enter size 1: "), GetInt("Enter size 2: "), 0, 15);

PrintTDArray(array, "Before sort: ");

SortArray(array);

PrintTDArray(array, "After sort: "); 