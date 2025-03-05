internal class Program
{
    private static void Main(string[] args)
    {
        int eded;
       eded= int.Parse(Console.ReadLine());
        if (eded > 0) {
            Console.WriteLine("eded musbetdir.");
        }
        else if(eded < 0)
        {
            Console.WriteLine("eded menfidir.");
        }
        else
        {
            Console.WriteLine("eded sifirdir.");
        }
    }
}