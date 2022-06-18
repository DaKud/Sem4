// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int fact(int a)
{
    int index = 1;
    int result = 1;
    while (index <= a)
    {
        result = result * index;
        index++;
    }
    return result;
}

Console.WriteLine ("insert number: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine (fact(num));