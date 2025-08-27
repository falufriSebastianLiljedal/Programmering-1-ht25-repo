namespace VariablerTe24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            int age;
            age = 30;
            bool isMarried = false;

            Console.WriteLine("Vad heter du då? ");
            firstName = Console.ReadLine();

            Console.WriteLine(firstName + " är fett gammal, typ " + age);

          
        }
    }
}
