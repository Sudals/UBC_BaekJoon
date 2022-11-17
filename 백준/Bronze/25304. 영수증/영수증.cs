int sum = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            string[] tmp;
            for (int i = 0; i< n; i++)
            {
                tmp = Console.ReadLine().Split(" ");
                s += int.Parse(tmp[0]) * int.Parse(tmp[1]);
            }
            if (sum == s)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }