namespace IfVisaTe24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are " + age + " years old.");

            bool isAlive = true;
            bool isMarried = false;

            // && AND
            // || OR
            // ! NOT
            // < smaller
            // > greater
            // <= smaller or equal
            // == equal

            if(isAlive)
            {
                if(isMarried)
                {
                    Console.WriteLine("You are alive and married");
                }
                else
                {
                    Console.WriteLine("You are alive and not married");
                }
            }
            else
            {
                if(isMarried)
                {
                    Console.WriteLine("You are not alive and married");
                }
                else
                {
                    Console.WriteLine("You are not alive and not married");
                }
            }

            if (isAlive || !isMarried)
            {
                Console.WriteLine("You are either alive or is not married");
            }



            if (30 <= age)
            {
                Console.WriteLine("Oldie!");
            }
            else if (18 < age)
            {
                Console.WriteLine("Welcome!");
            }
            else if(age == 18)
            {

            }
            else
            {
                Console.WriteLine("Access denied - You must be at least 18 years old.");
            }
            Console.WriteLine("Goodbye!");
        }
    }
}
