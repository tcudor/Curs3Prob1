namespace Curs3Prob1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti textul: ");
            string? text = Console.ReadLine();

            Console.Write("Introduceti textul cautat: ");
            string? substring = Console.ReadLine();

            
            text = text.ToLower();
            substring = substring.ToLower();

            int count = CautaText(text, substring);

            Console.WriteLine($"Nr de aparitii este: {count}");

        }

        static int CautaText(string text, string substring)
        {
            int count = 0;
            int index = text.IndexOf(substring);

            while (index != -1)
            {
                count++;
                index = text.IndexOf(substring, index + 1);
            }

            return count;
        }
    }
}