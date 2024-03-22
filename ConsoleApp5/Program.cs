namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { -2, 5, -8, 10, 3, -1, 0 };

            Func<int[], int> countPositiveNumbers = nums => nums.Count(num => num > 0);

            int count = countPositiveNumbers(numbers);

            Console.WriteLine($"Кількість позитивних чисел у масиві: {count}");
        }
    }
}