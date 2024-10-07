using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeAnimales.Models
{
    //Clase que representa un perro
    public class Perro: Animal
    {
        //Sobreescribir el método HacerSonido()
        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} dice ¡Guau!");
        }
    }
}
