/*
Задача 37(сложная необязательная): Найдите произведение пар чисел в одномерном массиве.
 Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
 Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
int [] fillArray(int length)
{
    int [] massive=new int [length];
    for (int i = 0; i < length; i++)
    {
        massive[i]=new Random().Next(0,11);
    }
    return massive;
}
int [] multOfNumbersArray(int[] collection)
{
    int [] array=new int [(collection.Length+1)/2];
    for (int i = 0; i < collection.Length/2; i++)
    {
       array[i] =collection[i]*collection[collection.Length-1-i];
    }
    if (collection.Length%2==1) array[collection.Length/2]=collection[collection.Length/2];
    return array;
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
Console.Write("парные произведения=");
ourArray=multOfNumbersArray(ourArray);
printArray(ourArray);