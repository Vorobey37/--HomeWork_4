/*
Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Clear();
Console.WriteLine("Введите число А:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int B = int.Parse(Console.ReadLine());

while (B <= 0)
{
    Console.WriteLine("Число B не натуральное!!!");
    Console.WriteLine("Введите НАТУРАЛЬНОЕ число B:");
    B = int.Parse(Console.ReadLine());
}

int APowB(int A, int B)
{
    int r = A;
    for (int i=1; i<B; i++)
    {
        r=r*A;
    }
    return r;
}
Console.WriteLine($"{A}, {B} -> {APowB (A, B)}");



