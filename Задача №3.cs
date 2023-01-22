internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string UserString = Console.ReadLine();

        UserString = UserString.ToLower().Replace(" ", "");

        char[] ASKLJFLAKSJD = UserString.ToCharArray();
        Array.Reverse(ASKLJFLAKSJD);

        for (int i = 0; i < UserString.Length; i += 2)
        {
            ASKLJFLAKSJD[i] = ' ';
        }

        string Res = new string(ASKLJFLAKSJD);

        Res = Res.ToLower().Replace(" ", "");

        Console.Write($"Четные символы в вашей строке в обратном порядке: {Res}");
    }
}