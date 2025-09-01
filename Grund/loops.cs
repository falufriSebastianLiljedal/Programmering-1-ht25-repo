namespace LooparTe24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 20;
            for(int i = 0; i<number; i++)
            {
                Console.WriteLine(i + ". NaTe24_1 var bäst på brännboll!");
            }

            int index = 0;

            while (index < number)
            {
                Console.WriteLine(index + ". NaTe24_1 var bäst på brännboll!");
                index++;
            }

            int choice = 1;
            while (choice !=0)
            { 
                //Användaren att göra val
                Console.WriteLine("|--------------------------|");
                Console.WriteLine("|1. Ge mig ditt bästa citat|");
                Console.WriteLine("|2. Koka kaffe tack        |");
                Console.WriteLine("|                          |");
                Console.WriteLine("|0. Stäng av               |");
                Console.WriteLine("|--------------------------|"); 
                choice = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
