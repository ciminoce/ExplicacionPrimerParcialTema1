namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Rombos!");
            double mayorSuperficie = 0;
            int iteracion = 0;
            double promedioSuperficie = 0;
            int DM, dm;
            for (int i = 1; i <= 5; i++)
            {
                do
                {
                    Console.Write("Ingrese el valor de diagonal mayor:");
                    if (int.TryParse(Console.ReadLine(),out DM) && DM>0)
                    {
                        break;
                    }
                    Console.WriteLine("Diagonal mal ingresada...");
                } while (true);
                do
                {
                    Console.Write("Ingrese el valor de diagonal menor:");
                    if (int.TryParse(Console.ReadLine(), out dm) && (dm > 0 && dm<DM))
                    {
                        break;
                    }
                    Console.WriteLine("Diagonal mal ingresada...");
                } while (true);

                var ladoRombo = Math.Sqrt(Math.Pow(DM / 2, 2) + Math.Pow(dm / 2, 2));
                var perimetro = ladoRombo * 4;
                var superficie = (DM * dm) / 2;
                Console.WriteLine($"Rombo {i}");
                Console.WriteLine($"Rombo de lado: {ladoRombo}");
                Console.WriteLine($"Superficie: {superficie}");
                Console.WriteLine($"Perímetro: {perimetro}");
                promedioSuperficie+=superficie;
                if (superficie>mayorSuperficie)
                {
                    mayorSuperficie = superficie;
                    iteracion = i;
                }
            }
            promedioSuperficie /= 5;
            Console.WriteLine($"Promedio de Superficies: {promedioSuperficie}");
            Console.WriteLine($"Mayor superficie: {mayorSuperficie}");
            Console.WriteLine($"Ingresada en iteración nro: {iteracion}");
        }
    }
}
