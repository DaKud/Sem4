int NumberSum(int A)
{
    int sum = 0;
    while ( A != 0)
    {
        sum += A % 10;
        A /= 10;
    }
    return sum;
}

Console.WriteLine("Insert number: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Sum of digits in the number "+ A + "=" + NumberSum(A));
