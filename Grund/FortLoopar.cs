namespace FortLoopar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //udouasdi9asbdoasbd9uabsd9uabsd9uabs9udba
            //for(int i = 0; i<10; i++)
            //{
            //    Console.WriteLine($"Hello, World! {i}");
            //}
            //
            //
            //int index = 0;
            //while(index < 10)
            //{
            //    Console.WriteLine($"Hello, World! {index}");
            //    index++;
            //}
            //
            //int choice = 0;
            //
            //do
            //{
            //    choice = Convert.ToInt32(Console.ReadLine());
            //
            //} while (choice !=0);

            int size = 20;

            for(int i = 0; i <size; i++)
            {
                for(int j = 0; j <size; j++)
                {
                    //Console.Write($"( {i}, {j})  ");
                }
                Console.WriteLine();
            }

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };  
            numbers.Sort();
        }
    }
}
