namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int satirSayisi = 6; 
            for (int i = 1; i <= satirSayisi; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();
            }



        }
    }
}
