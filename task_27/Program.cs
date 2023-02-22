/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.Clear();
Console.WriteLine("Введите число:");
int A = int.Parse(Console.ReadLine());
int SumNumbers (int A)
{
    if (A<0)
    {
        A = A*(-1);
    }
    int B = A;
    int N = 1;

    for (int n=2; A>9; n++)
    {
        A=A/10;
        N = n;
    }
    
    int Pow10(int N)
{
    int r = 10;
    for (int i=1; i<N; i++)
    {
        r=r*10;
    }
    return r;
}
   
    int sum = B/Pow10(N-1) + B%10;
    
    if (N==1)
    {
        sum = B;
    }

   for (; N>2; N--)
    {
       sum = sum + (B%Pow10(N-1))/Pow10(N-2);
    }
    return sum;
}
Console.WriteLine($"{A} -> {SumNumbers(A)}");
