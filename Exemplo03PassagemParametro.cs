using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutorCsharp
{
    internal class Carro

    {
        public string cor;

        public Carro (string corDoCarro)
        {
            cor = corDoCarro;
        }

        public static void Main(string[] args)
        {
            Carro byd = new Carro("Azul turqueza Fosco"); 

            Console.WriteLine("A cor desse carro é: " + byd.cor + ".");
        }
    }
}
