int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
for (int i = b; i <= a; i++)
{
    int s = 0;
    int crnt = i;

    while (crnt != 0)
    {
        int tmp = crnt % 10;
        s = s + tmp;
        crnt /= 10;
    }
    Console.WriteLine($"Сумма цифр {i} = {s}");
}