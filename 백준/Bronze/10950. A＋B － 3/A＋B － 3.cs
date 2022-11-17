int n = int.Parse(Console.ReadLine());
string a=string.Empty;
for (int i = 0; i < n; i++)
{
    a += Console.ReadLine()+" ";
}
string[] tmp = a.Split("\n");
string[] arr = a.Split(" ");
for (int i = 0; i < arr.Length-1;i+=2)
{
    int tmpN=int.Parse(arr[i]) + int.Parse(arr[i + 1]);
    Console.WriteLine(tmpN);
}
            

