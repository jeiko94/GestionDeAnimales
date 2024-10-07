using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeAnimales.Models
{
    //Clase base que representa un animal
    public class Animal
    {
        //Propiedad que almacena el nombre del animal "es parecido a un modelo de base de datos, estructura de una tabla"
        public string Nombre { get; set; }

        //Método virtual que representa el sonido que hace el animal, las clases virtuales pueden ser sobreescritas
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }
    }
}
