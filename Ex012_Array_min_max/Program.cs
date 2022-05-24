// 6 8 3 2 1 4 5 7
// отсортировть от мин до макс
// 1. Найте позицию min элемента в несортированной части массива
// 2. Произвести обмен этого значения со значением первой несортированной позиции
// 3. Повторять пока есть несортированные элементы.

int [] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintAray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;
    
        for (int j = i+1; j < array.Length; j++) //блок кода 27-30 ищет максимальный элемент
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i]; // блок кода 32-34 - производится свап(обмен)
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintAray(arr);
SelectionSort(arr);
PrintAray(arr);
// finish added to index add and commit 


