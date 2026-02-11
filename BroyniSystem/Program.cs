namespace BroyniSystem
{
    internal class Program
    {
        private static void Main(String[] args)
        {
            Console.Write("Въведете десетично число: ");
            int n = int.Parse(Console.ReadLine());
            string binary = "";
            while (n > 0)
            {
                binary = (n % 2) + binary;
                n /= 2;
            }
            Console.WriteLine($"Двоично: {binary}");
        }
    }
}