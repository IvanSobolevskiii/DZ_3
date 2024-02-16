int[] TurnOver(int[] array)
{
    int[] arr = array;

    for(int i = 0, i2 = array.Length - 1; i < array.Length / 2; i++, i2--)
    {
        int TemVar1 = array[i];
        int TemVar2 = array[i2];
        arr[i] = TemVar2;
        arr[i2] = TemVar1;
    }

    return arr;
}

int[] StaticArray = {23, 76, 34, 73, 34, 99};
int[] res = TurnOver(StaticArray);
Console.Write($"Массив : [ {string.Join(" ; ", res)} ]");