int[] numbers = { -63, 64, -5, -3, 45, -4, 54, 45, 8 };
int save;
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] > numbers[j])
        {
            save = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = save;
        }
    }
}

foreach (int i in numbers)
{
    Console.Write(i+" ");
}




