class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            int num = int.Parse(input[i]);
            sum += num * num;
        }
        int result = sum % 10;
        Console.WriteLine(result);
    }
}