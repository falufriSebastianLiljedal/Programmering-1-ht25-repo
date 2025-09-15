namespace FunctionsVisa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Sebastian";
            PrintMenu("Conny", 70, true);
        }

        static void PrintMenu(string name, int age, bool isMarried)
        {
            Console.WriteLine("-------------"+name+"------------");
            Console.WriteLine("|Massa olika menyval|");
            Console.WriteLine("|Massa olika menyval|");
            Console.WriteLine("|Massa olika menyval|");
            Console.WriteLine("|Massa olika menyval|");
            Console.WriteLine("|Massa olika menyval|");
            Console.WriteLine("-------------------------------------");
        }

        static int Add(int first, int second)
        {
            return first + second;
        }
    }
}
