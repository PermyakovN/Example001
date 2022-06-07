int count = 0;
int S = 10000;
int V1 = 1;
int V2 = 2;
int Vd = 5;
int T = 0;
int friend = 2;
while (S > 10)

{
    if (friend == 1)

    {
        T = S / ( V2 + Vd);
        friend = 2;
    }

    if (friend == 2)

    {
        T = S / (V1 + Vd);
        friend = 1;
    }

    S = S - (V1 + V2) * T;
    count = count + 1;
}
Console.Write("Собака пробежит =");
Console.WriteLine(count);