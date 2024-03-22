namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Func<int, double> calculateCube = number =>
            {
                double square = Math.Pow(number, 2);
                return square * number;
            };

            int testNumber = 4;
            Console.WriteLine($"Куб числа {testNumber} дорівнює: {calculateCube(testNumber)}");
        }
    }
}
