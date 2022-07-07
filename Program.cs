// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
/*Console.WriteLine("Введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum += num;
}
Console.WriteLine("Сумма всех цифр в числе равна: " + sum);*/


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int [] array = new int[10];


void PrintArray(int[] arr)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        arr [i] = new Random().Next(1, 10);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

PrintArray(array);