using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutorCsharp
{
    internal class ExemploConstrutor02
    {
        public string marca;


        public ExemploConstrutor02()
        {
            marca = "Nike";
        }
          
        public static void Main(string[] args)
        {
           ExemploConstrutor02 Ford = new ExemploConstrutor02();

            Console.WriteLine("A marca desse tênis é: " + Ford.marca + ".");
        }
        
    }

}
