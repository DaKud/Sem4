// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

// int func(int size)
// {
//     int sum = 0;
//     for (int i = 0; i<=size; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

Console.WriteLine ("insert number: ");
int A = int.Parse(Console.ReadLine());
int digit(int A)
{
    int count = 0;

    while (A != 0)
    {
    A = A / 10;
    count++;
    }

    return count;
}
Console.WriteLine(digit(A));
