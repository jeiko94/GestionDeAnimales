using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeAnimales.Models
{
    public class Pajaro: Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} Canta una molodia");
        }
    }
}
