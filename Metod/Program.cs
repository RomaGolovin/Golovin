void Multiply(params int[] massiv)
{
    int j = 1;
    foreach (var i in  massiv)
    {
      j *= i;
    }
    Console.WriteLine("Решение " + j);
}
int[] some = [3,6,2];

Multiply(some);
Multiply(3, 2, 2);
