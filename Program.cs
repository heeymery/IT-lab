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
        int a, b, c, sum;
        Console.WriteLine("Ededleri daxil edin:");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        sum = a + b + c; 
        Console.WriteLine("Cəm: " + sum);
    }
}
