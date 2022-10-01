/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double [] fillArray(int length)
{
    double [] massive=new double [length];
    for (int i = 0; i < length; i++)
    {
        massive[i]=new Random().Next(0,700);
    }
    return massive;
}
double [] sortMassive (double[] collection)
{   
    for (int i = 0; i < collection.Length-1; i++)
    {
        int minPosition=i;
        for (int j = i+1; j <collection.Length; j++)
        { 
            if (collection[j]<collection[minPosition]) minPosition=j;
        }
        double temp=collection[i];
        collection[i]=collection[minPosition];
        collection[minPosition]=temp;
    }
    return collection;
}
void printArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length-1]}]");
}
Console.WriteLine("введите длину массива");
int userLength=Convert.ToInt32(Console.ReadLine());
double [] ourArray=fillArray(userLength);

for (int i = 0; i < ourArray.Length; i++)
{
    ourArray[i]=ourArray[i]/(Math.Sqrt(2));   
}
Console.WriteLine($"в массиве:");
printArray(ourArray);
double [] sortArray=sortMassive(ourArray);
Console.WriteLine($"максимальное значение = {sortArray[sortArray.Length-1]}, ");
Console.WriteLine($"минимальное значение = {sortArray[0]},");
Console.WriteLine($"а разница между MAX и MIN значениями равна: {sortArray[sortArray.Length-1]-sortArray[0]}");