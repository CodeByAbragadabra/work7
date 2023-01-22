internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string UserString = Console.ReadLine();

        string[] ArrayOfWords = UserString.Split(" ");

        if (ArrayOfWords.Length >= 2)
        {
            string Temp1 = ArrayOfWords[0];
            string Temp2 = ArrayOfWords[1];
            ArrayOfWords[0] = Temp2;
            ArrayOfWords[1] = Temp1;

            foreach (var i in ArrayOfWords)
            {
                Console.Write(i + " ");
            }
        }
        else { Console.WriteLine("Прости, но слишком коротко, надо бы два слова"); }
    }
}