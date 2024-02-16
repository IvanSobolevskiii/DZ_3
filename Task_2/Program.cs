int NumberEvenInt(int[] array)
{
    int NumberInt = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            NumberInt++;
        }

    }
    return NumberInt;
}

int[] array = {123, 546, 639, 434, 932, 434, 666, 923};
Console.Write(NumberEvenInt(array));

