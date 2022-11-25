using System;
class Program
{
    static void Main(string[] args)
    {
        int[] coin = new int[101];
        int[,] solution = new int[101, 100001];
        var split = Console.ReadLine().Split(' ');
        int n = int.Parse(split[0]), k = int.Parse(split[1]);
        for (int i = 1; i <= n; i++) coin[i] = int.Parse(Console.ReadLine());
        for (int i = 0; i <= n; i++) solution[i, 0] = 1;
        for (int j = 1; j <= k; j++) solution[1, j] = j % coin[1] > 0 ? 0 : 1;
        for (int i = 2; i <= n; i++)
            for (int j = 1; j <= k; j++)
                solution[i, j] = j < coin[i] ? solution[i - 1, j] : solution[i, j - coin[i]] + solution[i - 1, j];
        Console.Write(solution[n, k]);
    }
}