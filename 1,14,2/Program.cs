int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int s = 0;
for (int i = a; i <= b; i++)
{
    
        int crnt = i;
    int p =0;
    int tmp = 1;
    int k = i;

    if (crnt > 1)
    {
        while (p != 1 && tmp != 0)
        {
            p = crnt - 1;
            tmp = k % p;
            crnt = crnt - 1;

            if (p == 1)
            {
                s = s + 1;
            }
        }
    }
    else if (crnt == 1)
    {
        s = s + 1;
    }
    }
 Console.WriteLine(s); 

