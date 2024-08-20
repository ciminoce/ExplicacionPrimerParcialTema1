namespace Ejercicio01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Rombos!");
            Console.Write("Ingrese el valor de diagonal mayor:");
            var DM=int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de diagonal menor:");
            var dm = int.Parse(Console.ReadLine());

            var ladoRombo=Math.Sqrt(Math.Pow(DM/2,2) + Math.Pow(dm/2,2));
            var perimetro = ladoRombo * 4;
            var superficie = (DM * dm) / 2;
            Console.WriteLine($"Rombo de lado: {ladoRombo}");
            Console.WriteLine($"Superficie: {superficie}");
            Console.WriteLine($"Perímetro: {perimetro}");
        }
    }
}
