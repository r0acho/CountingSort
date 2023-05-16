//сортировка подсчетом

int[] array = {-10, -5, -9, 0, 2, 5, 1, 3, 1, 0, 1};
int[] sortedArray = CountingSortExtended(array);

//CountingSort(array);

Console.WriteLine(string.Join(", ", sortedArray));

void CountingSort(int[] inputArray)
{
    int[] counters = new int[10]; //массив повторений изначально заполнен нулями. Длина соответствует значению максимального элемента исходного массива

    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i]]++; //в ячейку массива counters с индексом,  соответствующим значению элемента исходного массива, добавляется единица, т.о. считается количество вхождений повторяющихся элементов
        // ourNumber = inputArray[i];
        // counters[ourNumber]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++) // внутренний цикл проходит по i-той ячейке массива counters столько раз, сколько указано в её значении
        {
            inputArray[index] = i; // ... и добавляет значение i  в отсортированный масив нужное количество раз
            index++;                // сдвигаем индекс, чтобы двигаться по отсортированному массиву
        }
    }
}


int[] CountingSortExtended(int[] inputArray) // метод для сортировки массивов со значениями больше десяти, включая отрицательные
{
    int max = inputArray.Max();
    int min = inputArray.Min();

    int offset = -min; //сдвиг относительно нуля в отрицательную, либо положительную сторону
    int[] sortedArray = new int[inputArray.Length];
    int[] counters = new int[max + offset + 1]; // +1, чтобы включить и первый и последний элемент диапазона



    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i] + offset]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            sortedArray[index] = i - offset;
            index++;
        }
    }

    return sortedArray;
}