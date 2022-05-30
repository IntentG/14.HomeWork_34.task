/*Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.[345, 897, 568, 234] -> 2*/

Console.WriteLine("Укажите длину массива: ");
int sizeArray = int.Parse(Console.ReadLine());


int[] array = new int[sizeArray];
Random arrayRandomValue = new Random();
int evenNumber = 0;

for (int i = 0; i < sizeArray; i++)
{
    array[i] = arrayRandomValue.Next(100, 999);
    Console.Write($" | {array[i]}");

        if (array[i] % 2 == 0) // условие проверки на чётность
            evenNumber++;
}

//////////////////////// Доп. условие - для более дружественного интерфейса к пользователю.
if (evenNumber == 0)
    Console.WriteLine(" \n В массиве остутсвуют чётные числа!");
else
    Console.WriteLine($" \n Количество чётных чисел в массиве = {evenNumber}");
