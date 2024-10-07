using System;
using System.Collections.Generic;
using GestionDeAnimales.Models;


namespace GestionDeAnimales.BusinessLogic
{
    //Clase que maneja la logica de negocio relacionada con animales
    public class AnimalService
    {
        //Lista que almacena los animales "yo lo veo una tabla que ya tiene sus atributos "Columnas creadas"
        private List<Animal> animales;

        //Constructor
        public AnimalService()
        {
            animales = new List<Animal>();
        }

        //Agregar un animal a la lista
        public void AgregarAnimal(Animal animal)
        {
            animales.Add(animal);
        }

        //Muestra los animales y sus sonidos
        public void MostrarAnimales()
        {
            foreach (var animal in animales)
            {
                animal.HacerSonido();
            }
        }

        //Contar cuántos animales hay de cada tipo
        public void ContarAnimales()
        {
            int perro = 0;
            int gatos = 0;
            int pajaros = 0;

            foreach (var animal in animales)
            {
                if (animal is Perro)
                    perro++;
                else if (animal is Gato)
                    gatos++;
                else if (animal is Pajaro)
                    pajaros++;
            }

            Console.WriteLine("\nCantida de animales: ");
            Console.WriteLine($"Perros {perro}");
            Console.WriteLine($"gatos {gatos}");
            Console.WriteLine($"pajaros {pajaros}");
        }
    }
}

