namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            string keyword = "машини";
            string textToCheck = "У нас є багато машин і мотоциклів.";

            Func<string, string, bool> checkTextForWord = (text, word) => text.ToLower().Contains(word.ToLower());

            bool containsWord = checkTextForWord(textToCheck, keyword);

            Console.WriteLine($"Текст містить слово \"{keyword}\": {containsWord}");
        }
    }
}