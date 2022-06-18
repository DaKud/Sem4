
// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array= new int[8];  //размер в [] 
void print (int[] arr1)
{
    for (int  i=0; i< arr1.Length; i++)
{
    Console.WriteLine(arr1[i]+"");
}
Console.WriteLine();
}

for (int  i=0; i< array.Length; i++)
{
    array[i]=new Random().Next(0,2);
}

print (array);