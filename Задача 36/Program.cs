/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[]Massive2x()
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
             Massive[i] = new Random().Next(-99,100);
        }
    return Massive;
}

// Далее рассчитываю как в задачке, где считаем с нуля и нечётные позиции это index 1, 3 итд.
int CalculateOdd(int[] Massive)
{
    int ResultOdd = 0;
    for (int i = 0; i < Massive.Length; i++)
        if ((i + 1) % 2 == 0)
        {
            ResultOdd += Massive[i];
        }
    return ResultOdd;
}

string PrintMassive(int[] Massive)
{
    string print = string.Join(", ", Massive);
    return print;
}

int[]Massive = Massive2x();
int Odd = CalculateOdd(Massive);

Console.WriteLine($"В массиве {PrintMassive(Massive)} сумма элементов, стоящих на нечётных позициях равна {Odd}");
