/*Task1 адайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

/*
int[] CreateRandomArray(int size)
{
    
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(99, 999);

        
    }
    return array;
}

int GetEven(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) 
            count++;
    }

    return count;


}


void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
    Console.WriteLine();
}

Console.Write("Input a lenght of array:  ");
int lenght = Convert.ToInt32(Console.ReadLine());

CreateRandomArray(lenght);

int[] newArray = CreateRandomArray(lenght);
ShowArray(newArray);

int result = GetEven(newArray);
Console.WriteLine("The number of even elements of this array is equal to  " + result);
*/

/*Task2. Задайте одномерный массив, 
заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*/

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);

        
    }
    return array;
}

int GetSumOfUnevenIndex(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i = i+2)
    {
        sum += array[i];
    }

    return sum;


}


void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
    Console.WriteLine();
}

Console.Write("Input a lenght of array:  ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value:  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:  ");
int max = Convert.ToInt32(Console.ReadLine());


CreateRandomArray(lenght, min, max);

int[] newArray = CreateRandomArray(lenght, min, max);
ShowArray(newArray);

int result = GetSumOfUnevenIndex(newArray);
Console.WriteLine("Sum of negatives in this array is  " + result);

*/

/* Task3. Specify an array of real numbers. 
Find the difference between the maximum and minimum array elements.*/

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(minValue, maxValue);

        
    }
    return array;
}

/*int GetSumOfUnevenIndex(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i = i+2)
    {
        sum += array[i];
    }

    return sum;


}

*/
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
    Console.WriteLine();
}

Console.Write("Input a lenght of array:  ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value:  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:  ");
int max = Convert.ToInt32(Console.ReadLine());


CreateRandomArray(lenght, min, max);

double[] newArray = CreateRandomArray(lenght, min, max);
ShowArray(newArray);

/*int result = GetSumOfUnevenIndex(newArray);
Console.WriteLine("Sum of negatives in this array is  " + result);*/