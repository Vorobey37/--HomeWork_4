/*
Задан массив a[1..n] из n неотрицательных целых чисел. Необходимо реализовать следующие операции над ним:

get(i) – извлечение элемента с номером i;
update(l,r,x) – присвоение значения x всем элементам подмассива a[l..r];
add(l,r,x) – увеличение всех элементов a[l..r] на x;
rsq(l,r) – вычисление суммы всех элементов a[l..r], т.е. значения a[l]+a[l+1]+…+a[r];
rmq(l,r) – вычисление минимального элемента среди всех значений a[l..r].
Входные данные
Первая строка входного файла содержит число n – размер массива. 
Во второй строке записаны n целых неотрицательных чисел – элементы массива. 
Третья строка содержит натуральное число m – количество запросов. 
Следующие m строк содержат запросы в формате, представленном в примере. 
Все числа во входных данных не превосходят 1000.
*/
Console.Clear();
int N = new Random().Next(1, 11);
Console.WriteLine(N);
int [] mass = new int [N];
for (int j=0; j<N; j++)
{
    mass[j] = new Random().Next(1, 11);
    Console.Write($"{mass[j]} ");
}
Console.WriteLine();
//Console.WriteLine("5");
Console.WriteLine("get(i) – извлечение элемента с номером i");
Console.WriteLine("update(l,r,x) – присвоение значения x всем элементам подмассива a[l..r];");
Console.WriteLine("add(l,r,x) – увеличение всех элементов a[l..r] на x;");
Console.WriteLine("rsq(l,r) – вычисление суммы всех элементов a[l..r], т.е. значения a[l]+a[l+1]+…+a[r];");
Console.WriteLine("rmq(l,r) – вычисление минимального элемента среди всех значений a[l..r]");
int i = new Random().Next(0, N-1);
Console.Write ($"get(i): i={i} -> ");

int get(int i)
{
    int a = mass[i];
    return a;
}
Console.WriteLine(get(i));


int l = new Random().Next(0, N-1);
int r = new Random().Next(0, N-1);
int x = new Random().Next(0, 11);
if (r<l)
{
    int b = l;
    l = r;
    r = b;
}
//Console.Write ($"update(l,r,x): l={l}, r={r}, x={x} -> ");

int [] update (int l, int r, int x)
{
    for (int j=0; j<l; j++)
    {
        mass[j] = get(j);
        Console.Write($"{mass[j]} ");
    }
    for (int j=l; j<=r; j++)
    {
        mass[j] = x;
        Console.Write($"{mass[j]} ");
    }
    for (int j=r+1; j<N; j++)
    {
        mass[j] = get(j);
        Console.Write($"{mass[j]} ");
    }
    return mass;
}
//int [] UD = update (l, r, x);
//Console.WriteLine();

//Console.Write ($"add(l,r,x): l={l}, r={r}, x={x} -> ");
int [] add (int l, int r, int x)
{
    for (int j=0; j<l; j++)
    {
        mass[j] = get(j);
        Console.Write($"{mass[j]} ");
    }
    for (int j=l; j<=r; j++)
    {
        mass[j] = get(j) + x;
        Console.Write($"{mass[j]} ");
    }
    for (int j=r+1; j<N; j++)
    {
        mass[j] = get(j);
        Console.Write($"{mass[j]} ");
    }
    return mass;
}
//int [] AD = add (l, r, x);
//Console.WriteLine();
int rsq (int l, int r)
{
    int sum = 0;
    if (l==r)
    {
        sum = get(l);
    }
    else for (int j=l; j<=r; j++)
    {
        sum = sum + get(j);
    }
    return sum;
}
Console.WriteLine ($"rsq(l,r): l={l}, r={r} -> {rsq (l, r)}");

int rmq (int l, int r)
{
    int min = get(l);
    for (int j=l; j<=r; j++)
    {
        if (get(j)<min)
        {
            min = get(j);
        }
    }
    return min;
}
Console.WriteLine ($"rmq(l,r): l={l}, r={r} -> {rmq (l, r)}");
