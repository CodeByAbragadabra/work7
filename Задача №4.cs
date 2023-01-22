internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string UserStr = Console.ReadLine();

        string[] ArrayOfWords = UserStr.Split(" ");

        foreach (string i in ArrayOfWords)
        {
            Console.Write(i.Substring(1) + " ");
        }
    }
}