/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[]Massive3xx()
{
    int length;
    Console.Write($"Введите количество элементов массива: ");
    int.TryParse(Console.ReadLine()!, out length);
    if (length < 0)
        {
            Console.WriteLine($"Вы ввели не натуральное число, пожалуйста перезапустите программу");
            Environment.Exit(0);
        }
    int[]Massive = new int[length];
    for (int i = 0; i < Massive.Length; i++)
        {
             Massive[i] = new Random().Next(100,1000);
        }
    return Massive;
}

int CalculateEven(int[] Massive)
{
    int ResultEven = 0;
    for (int i = 0; i < Massive.Length; i++)
        if (Massive[i] % 2 == 0)
            ResultEven++;
    return ResultEven;
}

string PrintMassive(int[] Massive)
{
    string print = string.Join(", ", Massive);
    return print;
}

int[]Massive = Massive3xx();
int Even = CalculateEven(Massive);

Console.WriteLine($"В массиве {PrintMassive(Massive)} количество чётных чисел равно {Even}");