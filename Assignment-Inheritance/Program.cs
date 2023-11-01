namespace MultiLevelInhritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Result result = new Result();
            result.GetDetails();
            result.CalulateTotalScore();
            result.DisplayDetails();
        }
    }
}