namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Func<int, bool> checkEven = delegate (int number)
            {
                return number % 2 == 0;
            };

            int testNumber = 8;
            Console.WriteLine($"Число {testNumber} парне: {checkEven(testNumber)}");

            testNumber = 9;
            Console.WriteLine($"Число {testNumber} парне: {checkEven(testNumber)}");
        }
    }
}