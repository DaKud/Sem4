// // See https://aka.ms/new-console-template for more information
// //Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Insert number : ");
// int A = int.Parse(Console.ReadLine());

// if (A<0)
// {
//     Console.WriteLine("Insert positive number");
//     return;
// }


// int sum = 0;
// for (int i = 0; i <= A; i++)
// {
//     sum += i;
// }
// Console.WriteLine(sum);

int func(int size)
{
    int sum = 0;
    for (int i = 0; i<=size; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine("Insert number: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Result A: " + func(A));
Console.WriteLine("Result 4: " + func(4));
Console.WriteLine("Result 8: " + func(8));
Console.WriteLine("Result -4:" + func(-4));
Console.WriteLine("Result 1000:" + func(10000));