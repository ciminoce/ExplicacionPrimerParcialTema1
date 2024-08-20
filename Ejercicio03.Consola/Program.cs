using Ejercicio03.Entidades;

namespace Ejercicio03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, Rombo Struct!");
            Console.Write("Ingrese el valor de diagonal mayor:");
            var DM = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de diagonal menor:");
            var dm = int.Parse(Console.ReadLine());
            Rombo r = new Rombo(DM, dm);
            Console.WriteLine(r.GetInfo());

        }
    }
}
