int DoOperation(char s, int a, int b)
{
    int result = s switch
    {
        '-' => a - b,
        '+' => a + b,
        '*' => a * b,
        '\0' => a * b,
        _ => throw new NotImplementedException()
    };
return result;
}

Console.WriteLine(DoOperation(' ', 4, 6));