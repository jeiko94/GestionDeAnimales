using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeAnimales.Models
{
    //La clase Gato hereda de la clase Animal()
    public class Gato: Animal
    {
        //Sobreescribimos el método HacerSonido() implementamos el polimorfismo
        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} dice ¡Miau!"); 
        }
    }
}
