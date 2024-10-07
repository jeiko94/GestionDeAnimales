using GestionDeAnimales.BusinessLogic;
using GestionDeAnimales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeAnimales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos el servicio de animales
            AnimalService animalService = new AnimalService();

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n--- Menú de animales ---");
                Console.WriteLine("1. Agregar perro");
                Console.WriteLine("2. Agregar gato");
                Console.WriteLine("3. Agregar pajaro");
                Console.WriteLine("4. Mostrar animales");
                Console.WriteLine("5. Contar animales");
                Console.WriteLine("6. Salir");
                Console.WriteLine("Seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch( opcion)
                {
                    case 1:
                        AgregarPerro(animalService);
                        break;
                    case 2:
                        AgregarGato(animalService);
                        break;
                    case 3:
                        AgregarPajaro(animalService);
                        break;
                    case 4:
                        animalService.MostrarAnimales();
                        break;
                    case 5:
                        animalService.ContarAnimales();
                        break;
                    case 6:
                        salir = true;   
                        break;
                    default:
                        Console.WriteLine("Opción invalida, vuelva a intentar.");
                        break;
                }
            }
        }

        static void AgregarPerro(AnimalService animalService)
        {
            Console.WriteLine("Ingresa el nombre del perro: ");
            string nombre = Console.ReadLine();
            
            Perro perro = new Perro { Nombre = nombre };
            animalService.AgregarAnimal(perro);
            Console.WriteLine("Perro agregado exitosamente.");
        }

        static void AgregarGato(AnimalService animalService)
        {
            Console.WriteLine("Ingrese el nombre del gato: ");
            string nombre = Console.ReadLine();
            Gato gato = new Gato { Nombre = nombre };
            animalService.AgregarAnimal(gato);
            Console.WriteLine("Gato agregado exitosamente");
        }

        static void AgregarPajaro(AnimalService animalService)
        {
            Console.WriteLine("Ingresa el nombre del pajaro: ");
            string nombre = Console.ReadLine();
            Pajaro pajaro = new Pajaro { Nombre = nombre };
            animalService.AgregarAnimal(pajaro);
            Console.WriteLine("Pajaro agregado exitosamente");
        }

    }
}
