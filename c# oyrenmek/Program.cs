for (int n = 2; n <= 100; n++)
{
    int i = 2;
    int bolenSayi = 0;

    while (i * i <= n)
    {
        if (n % i == 0)
        {
            bolenSayi = bolenSayi + 1;
        }
        i = i + 1;
    }

    if (bolenSayi == 0)
    {
        Console.WriteLine(n);
    }
}    
