internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите строку, а программа проверит ее на палиндром: ");
        string UserString = Console.ReadLine();

        UserString = UserString.ToLower().Replace(" ", "");

        string Copy = UserString;

        char[] ArrayOfUserStr = UserString.ToCharArray();

        Array.Reverse(ArrayOfUserStr);

        string Ready = new string(ArrayOfUserStr);

        if (Ready == Copy)
        {
            Console.Write("Результат: Строка является палиндромом");
        }
        else { Console.Write("Результат: Строка не является палиндромом"); }
    }
}