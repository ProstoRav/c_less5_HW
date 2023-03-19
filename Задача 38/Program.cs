/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int length;
    Console.Write($"Введите количество элементов массива: ");
    int.TryParse(Console.ReadLine()!, out length);
    if (length < 0)
        {
            Console.WriteLine($"Вы ввели не натуральное число, пожалуйста перезапустите программу");
            Environment.Exit(0);
        }
double[]Massive = new double[length];

void RandomMassiveDouble(int length)
{
    Random rand = new Random();
    for (int i = 0; i < length; i++)
        {
            Massive[i] = rand.NextDouble();
        }
}

double VarMinMax(double[] Massive)
{
    double min = Massive[0], max = Massive[0]; 
    int i = 1;
    while (i < Massive.Length)
    {
        if (max < Massive[i])
            max = Massive[i];
        if (min > Massive[i])
            min = Massive[i];
        i = i + 1;
    }
    return (max - min);
}

void PrintMassive(double[] Massive)
{
    Console.Write("[ ");
    for(int i = 0; i < Massive.Length; i++)
        {
            Console.Write($"{Massive[i]:F2} ");
        }
    Console.Write("] ");
}

RandomMassiveDouble(length);
Console.Write($"В массиве ");
PrintMassive(Massive);
Console.Write($"разница между максимальным и минимальным элементов равна: {VarMinMax(Massive):F2}");