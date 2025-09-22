namespace ListorArrayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Sebastian");
            names.Add("Greger");
            names.Add("Tård");

            names.Sort();
            names.RemoveAt(0);
            for (int i = 0; i <  names.Count; i++)
            {
                Console.WriteLine(names[i]);    
            }

            string[] arrNames = new string[10];
            arrNames[0] = "Sebastian";
            arrNames[1] = "";
            arrNames[2] = "Tård";
            arrNames[1] = "Greger";
            arrNames[0] = null;
            
            

            for(int i = 0;i < arrNames.Length;i++)
            {
                Console.WriteLine(i + ". " + arrNames[i]);
            }

        }
    }
}
