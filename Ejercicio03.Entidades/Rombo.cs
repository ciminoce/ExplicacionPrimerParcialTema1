using System.Text;

namespace Ejercicio03.Entidades
{
    public struct Rombo
    {
        public int DM { get; set; }
        public int dm { get; set; }
        public Rombo(int diagMayor, int diagMenor) {
            DM= diagMayor;
            dm= diagMenor;
        }
        public double GetLadoRombo()
        {
            return Math.Sqrt(Math.Pow(DM / 2, 2) + Math.Pow(dm / 2, 2));
        }
        //public double ladoRombo=> Math.Sqrt(Math.Pow(DM / 2, 2) + Math.Pow(dm / 2, 2));
        public double GetPerimetro=> GetLadoRombo() * 4;
        public double GetSuperficie => (DM * dm) / 2;

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rombo de DM:{DM}");
            sb.AppendLine($"Rombo de dm:{dm}");
            sb.AppendLine($"Valor del lado:{GetLadoRombo()}");
            sb.AppendLine($"Superficie: {GetSuperficie}");
            sb.AppendLine($"Perímetro: {GetPerimetro}");

            return sb.ToString();
        }
    }
}
