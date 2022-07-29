
string[] CreateArray()
{
    Console.Write("Ведите длинну массива => ");
    string number = Console.ReadLine();
    int large = int.Parse(number);
    string[] array = new string[large];

    for (int count = 0; count < large; count++)
    {
        Console.Write($"Ведите элемент   {count + 1} => ");
        array[count] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}; ");
    }
}

void CalculateSize(string[] array1)
{
    int n = 0;
    for (int count = 0; count < array1.Length; count++)
    {
        if (array1[count].Length <= 3)
        {
            n++;
        }
    }
    if (n == 0)
    { Console.WriteLine("Элементы меньше 4-х символов отсутствуют"); }
    else
    {
        string[] array2 = new string[n];
        int i = 0;
        for (int count = 0; count < array1.Length; count++)
        {
            if (array1[count].Length <= 3)
            {

                array2[i] = array1[count];
                i++;
            }

        }
        Console.WriteLine();
        for (int j = 0; j < array2.Length; j++)
        {
            Console.Write($"{array2[j]}; ");
        }
    }
}

string[] mass1 = CreateArray();


PrintArray(mass1);
CalculateSize(mass1);


