
while (true)
{
    Console.Write("Введите число: ");
    string text = Console.ReadLine();

    int number;

    if (text == "q")
    {
        break;
    }
    else if (int.TryParse(text, out number))
    {
        int SumNumber = 0;
        while(number > 0)
        {
            int TemVar = 0;
            TemVar = number % 10;
            number = number / 10;
            SumNumber = SumNumber + TemVar;
        }
        
        if (SumNumber % 2 == 0)
        {
            break;
        }
    }
    
}

