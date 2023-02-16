int i, j, N = 11;
int center = N / 2;

for (i = 0; i < N; i++)
{
    for (j = 0; j < N; j++)
    {
        if (i <= center)
        {
            if (j >= center - i && j <= center + i)
                Console.Write("*");
            else
                Console.Write(" ");
        }
        else
        {
            if (j >= center + i - N + 1 && j <= center - i + N - 1)
                Console.Write("*");
            else
                Console.Write(" ");
        }
    }
    Console.WriteLine();
}
return 0;