/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int [] fillArray(int length)
{
    int [] massive=new int [length];
    for (int i = 0; i < length; i++)
    {
        massive[i]=new Random().Next(100,1000);
    }
    return massive;
}
int countOfEvenNumbersFromArray(int[] collection)
{
    int count=0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i]%2==0)
        count++;
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
Console.Write("количество четных чисел=");
Console.WriteLine(countOfEvenNumbersFromArray(ourArray));