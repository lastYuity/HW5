//Задайте массив из 12 элементов, заполненный случайными числами из 
//промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.

/*
int[] arrayCreate(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue,maxValue+1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int GetNegativeSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] < 0)
        sum += array[i];
    return sum;
}

Console.Write("input size for array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = arrayCreate(size, min, max);
ShowArray(newArray);
int result = GetNegativeSum(newArray);
Console.WriteLine("sum of negative elements is " + result);
*/

//Напишите программу замена элементов массива: положительные элементы замените 
//на соответствующие отрицательные, и наоборот.

/*
int[] arrayCreate(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue,maxValue+1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] GetNegativeSum(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] *= (-1);
    return array;
}

Console.Write("input size for array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = arrayCreate(size, min, max);
ShowArray(newArray);
int[] result = GetNegativeSum(newArray);
ShowArray(newArray);
Console.WriteLine(result);
*/

//Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.

/*
int[] arrayCreate(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue,maxValue+1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

bool GetNegativeSum(int[] array, int num)
{
    for(int i = 0; i < array.Length; i++)
       if( array[i] == num)
            return true;
    return false;
}


Console.Write("input size for array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("введите число которое мы ищем: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] copyarray = arrayCreate(size,min,max);

ShowArray(copyarray);
Console.WriteLine(GetNegativeSum(copyarray,num));
*/
//Задайте одномерный массив из m случайных чисел. Найдите количество 
//элементов массива, значения которых лежат в отрезке [a,b]

/*
int[] arrayCreate(int size)
{
    int[] array = new int[size];
    
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(-100,100);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int GetNegativeSum(int[] array, int a, int b)
{
    int units = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] > a && array[i] < b)
        units += 1;
    return units;
}

Console.Write("input size for array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("input unit a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("input unit b: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] newArray = arrayCreate(size);
ShowArray(newArray);
int result = GetNegativeSum(newArray,a,b);
Console.WriteLine(result);
*/