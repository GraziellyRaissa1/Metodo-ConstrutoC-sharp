using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutorCsharp
{
    internal class Carro01
    {
     public string nomeCarro;
     public string modeloCarro;
     public int anoCarro;
     public string corCarro;
     public string combustivelCarro;

        public Carro01( string nomeDoCarro, string modeloDoCarro, int anoDoCarro, string corDoCarro, string combustivelDoCarro ) 
        {
            nomeCarro = nomeDoCarro;
            modeloCarro = modeloDoCarro;
            anoCarro = anoDoCarro;
            corCarro = corDoCarro;
            combustivelCarro = combustivelDoCarro;
        }
        public static void Main(string[] args )
        {
            Carro01 byd = new Carro01("BYD", "Dolphin", 2025, "Preto Fosco" , "Eletrico");

            Console.WriteLine("O nome do carro é : " + byd.nomeCarro + ".");

            Console.WriteLine("O modelo do carro é : " + byd.modeloCarro + "."); 

            Console.WriteLine("A cor desse carro é : " + byd.corCarro + ".");
            
            Console.WriteLine("O combustivel desse carro é : " + byd.combustivelCarro + ".");
           
        }

    }
}
