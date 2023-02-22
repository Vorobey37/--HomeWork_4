/*
Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.Clear();
Console.WriteLine("Введите количество элементов массива:");
int N = int.Parse(Console.ReadLine());

int [] MassN(int N)
{
    int [] mass = new int [N];
    for (int i=0; i<N; i++)
    {
        mass[i] = new Random().Next(0, 20);
    }

    for (int i=0; i<N-1; i++)
    {
        Console.Write($"{mass[i]}, ");
    }
    Console.Write($"{mass[N-1]}");
    return mass;
}
int [] b = MassN(N);
void PrintMassN(int [] b)
{
    Console.Write(" -> [");
    for (int i=0; i<N-1; i++)
    {
        Console.Write($"{b[i]}, ");
    }
    Console.Write($"{b[N-1]}]");
}
PrintMassN(b);
// Второй способ вывода:
Console.Write(" -> [");
for (int i=0; i<N-1; i++)
{
    Console.Write($"{b[i]}, ");
}
Console.Write($"{b[N-1]}]");



