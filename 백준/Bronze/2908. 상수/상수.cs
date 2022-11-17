string[] input = Console.ReadLine().Split(' ');

string a = input[0][2].ToString() + input[0][1].ToString() + (input[0][0]).ToString();
string b = input[1][2].ToString() + input[1][1].ToString() + (input[1][0]).ToString();
Console.WriteLine(int.Parse(a) > int.Parse(b) ? a : b);
