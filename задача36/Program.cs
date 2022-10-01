/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int [] fillArray(int length)
{
    int [] massive=new int [length];
    for (int i = 0; i < length; i++)
    {
        massive[i]=new Random().Next(0,10);
    }
    return massive;
}
int SumOfNumbersFromOddPosition(int[] collection)
{
    int count=0;
    for (int i = 1; i < collection.Length; i+=2)
    {
        count+=collection[i];
    }
    return count;
}
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine($"{array[array.Length-1]}]");
}
Console.WriteLine("введите длину массива");
int userLength=Convert.ToInt32(Console.ReadLine());
Console.Write("в массиве: ");
int [] ourArray=fillArray(userLength);
printArray(ourArray);
Console.Write("сумма элементов на нечетных позициях=");
Console.WriteLine(SumOfNumbersFromOddPosition(ourArray));