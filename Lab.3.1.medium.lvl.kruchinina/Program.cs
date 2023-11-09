// 20 var
try
{
    Console.Write("Введите k:");
    int k = int.Parse(Console.ReadLine());
    double Z = 1;
    double S = 0;
    for (int j = -4; j <= k; j++)
    {
        if (j != 3) Z *= Math.Pow(k, j + 2) * j / (j - 3);
        for (int i = j; i <= k + 5; i++)
        {
            if (i != 11) Z += Math.Pow(Math.Sqrt(i + 5), 1.0 / 5) / (i - 11) - Math.Pow(k, 5 * i);
        }
    }
    Console.WriteLine($"Z={Z * S:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}