namespace gitCommitok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Lista = new List<int>();
            Console.WriteLine("Kérek egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            while (szam != 0)
            {
                Lista.Add(szam);
                foreach (var item in Lista)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
                Console.WriteLine("Kérek egy számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}