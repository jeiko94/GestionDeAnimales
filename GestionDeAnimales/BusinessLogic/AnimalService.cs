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
    }
}

