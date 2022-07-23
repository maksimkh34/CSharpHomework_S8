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

int[,] array = new int[4, 4];
int size = array.GetLength(0);
for(int i = 1; i < size+1; i++) array[0, i-1] = i;
for(int i = 5; i < size * 2; i++) array[i-4, 3] = i;
for(int i = 0, j = 10; i < size;     i++, j--) array[size-1, i] = j;
for(int i = 1, j = 12; i < size - 1; i++, j--) array[i, 0] = j;
for(int i = 1, j = 13; i < size - 1; i++, j++) array[1, i] = j;
for(int i = 1, j = 16; i < size - 1; i++, j--) array[2, i] = j;
PrintTDArray(array);