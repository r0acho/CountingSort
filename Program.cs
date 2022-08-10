//сортировка подсчетом

int[] array = {3, 2, 1, 5, 9};

CountingSort(array);

Console.WriteLine(string.Join(", ", array));

void CountingSort(int[] inputArray)
{
    int[] counters = new int[10]; //массив повторений

    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i]]++;
        // ourNumber = inputArray[i];
        // counters[ourNumber]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i;
            index++;
        }
    }
}

