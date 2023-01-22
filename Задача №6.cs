internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string UserString = Console.ReadLine();

        string Numbers = "", Punctuation = "", Words = "";

        foreach (var YES in UserString)
        {
            if (char.IsDigit(YES))
                Numbers += YES;

            else if (char.IsPunctuation(YES))
                Punctuation += YES;

            else { Words += YES; }
        }
        Console.WriteLine($"Цифры: {Numbers}");
        Console.WriteLine($"Знаки препинания: {Punctuation}");
        Console.WriteLine($"Слова: {Words}");
    }
}