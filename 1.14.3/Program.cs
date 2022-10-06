int a= Convert.ToInt32(Console.ReadLine());
int b= Convert.ToInt32(Console.ReadLine());
int tmpa = -1;
int tmpb = 0;
if (a < 0)
{
    a = -a;
}if (b < 0)
{
    b = -b;
}

while (tmpa!=tmpb && a!=0)
{
    tmpa = a % 10;
    a /= 10;

    int bb = b;
    while (bb != 0 && tmpa != tmpb)
    {
        tmpb = bb % 10;
        bb /= 10;
    }
}
if (tmpa == tmpb)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}