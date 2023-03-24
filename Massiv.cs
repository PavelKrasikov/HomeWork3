// Создать и вывести массив из 8 элементов
void FillArray(int[] arr)
{
    for (int ind = 0; ind < arr.Length; ind++)
    {
        arr[ind] = new Random().Next(0, 10);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}

int[] Mas = new int [8];
FillArray (Mas);
PrintArray (Mas);