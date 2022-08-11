using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtributoEnumeradores;

namespace AtributoEnumeradores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ver1 = Enumeradores.TipoTarjeta.AmericanExpress;
            var ver2 = Enumeradores.TipoTarjeta.AmericanExpress.GetHashCode();
            var ver3 = Enumeradores.TipoTarjeta.AmericanExpress.ToString();
            var ver4 = Enumeradores.TipoTarjeta.AmericanExpress.StringValue();

            Console.WriteLine($"ver1: {ver1}");
            Console.WriteLine($"ver2: {ver2}");
            Console.WriteLine($"ver3: {ver3}");
            Console.WriteLine($"ver4: {ver4}");

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
