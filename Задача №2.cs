internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string UserString = Console.ReadLine();

        UserString = UserString.ToLower().Replace(" ", "");

        Console.Write("Введите слово, которое ищите: ");
        string SearchWord = Console.ReadLine();

        bool WordIsTrue = UserString.Contains(SearchWord);

        if (WordIsTrue)
        {
            Console.WriteLine($"Ваше слово (\"{SearchWord}\") есть в тексте");
        }
        else { Console.WriteLine($"Ваше слово (\"{SearchWord}\") НЕТУ в тексте"); }
    }
}