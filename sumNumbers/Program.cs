namespace sumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int givenNumbers = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < givenNumbers; i++)
            {
                double numbersToSum = double.Parse(Console.ReadLine());
                sum += numbersToSum;
            }
            Console.WriteLine(sum);
        }
    }
}