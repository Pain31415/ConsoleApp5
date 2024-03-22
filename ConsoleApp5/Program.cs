namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { -2, -5, -2, 3, -1, 3, -1, 0 };

            Func<int[], int[]> uniqueNegativeNumbers = nums => nums.Where(num => num < 0).Distinct().ToArray();

            int[] uniqueNegatives = uniqueNegativeNumbers(numbers);

            Console.WriteLine("Унікальні, негативні числа у масиві:");
            foreach (int num in uniqueNegatives)
            {
                Console.WriteLine(num);
            }
        }
    }
}