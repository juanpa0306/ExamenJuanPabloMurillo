using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenJuanPabloMurillo
{
    internal class Cafeteria
    {
        static string[] orden = new string[5];
        static string nombre = "";
        static void MenuCafeteria() //muestra el menu de la cafeteria
        {
            Console.WriteLine("Menu cafeteria:");
            Console.WriteLine("-Cafe mocca");
            Console.WriteLine("-Cafe latte");
            Console.WriteLine("-Cafe espresso");
            Console.WriteLine("-Cafe capuccino");
            Console.WriteLine("-Cafe americano");
            Console.WriteLine("-Cafe frappé");
            Console.WriteLine("-Empanada de pollo");
            Console.WriteLine("-Empanada de carne");
            Console.WriteLine("-Sandwich de pollo");
            Console.WriteLine("-Sandwich de carne");
        }

        static void registrarOrden()
        {
            int i = 0;
            int cant = 0;


            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            
            MenuCafeteria();
            {
                for (i = 0; i < orden.Lenght; i++)
                {
                    Console.WriteLine("Ingrese los items del menu (max 5)");
                    orden[i] = Console.ReadLine();
                }
                Console.WriteLine("Orden registrada!");
            }
 
        }


        static void cambiarOrden()
        {
            int i = 0;
            string objPorEliminar = "";
            string objNuevo = "";
            Boolean encontrado = false;

            Console.WriteLine($"Orden de {nombre}");
            for (i = 0; i < orden.Length; i++)
            {
                Console.WriteLine(orden[i]);
            }

            Console.WriteLine("Digite el nombre del item que desea borrar de la orden: ");
            objPorEliminar= Console.ReadLine();
            
            for (i=0; i<orden.Length ; i++) //recorre el arreglo y valida si la entrada que se proceso es correcta o no 
            {
                if (orden[i] == objPorEliminar)
                {
                    Console.WriteLine("Ingrese el item nuevo");
                    objNuevo = Console.ReadLine();
                    orden[i] = objNuevo;
                    encontrado = true;
                }
                if (!encontrado)
                {
                    Console.WriteLine("El item no se encuentra en el menu");
                }

            }
          
            
        }

        static void mostrarOrden()
        {
            int i = 0;
            Console.WriteLine($"Orden de {nombre}");
            for (i = 0; i < orden.Length; i++)
            {
                Console.WriteLine(orden[i]);
            }
        }

        static void MenuPrincipal()
        {
            int opcion = 0;
            do
            {
               
                Console.WriteLine("1-Registrar orden");
                Console.WriteLine("2-Mostrar orden");
                Console.WriteLine("3-Cambiar orden");
                Console.WriteLine("4-Terminar de ordenar");
                Console.WriteLine("Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        registrarOrden();
                        break;
                    case 2:
                        mostrarOrden();
                        break;
                    case 3:
                        cambiarOrden();
                        break;
                    case 4:
                        Console.WriteLine("Procesando orden...");
                        Console.WriteLine("Listo tenga un buen dia");
                        break;
                }
            }
            while (opcion != 4);
        }

        static void Main(string[] args)
        {
            MenuPrincipal();
        }
    }
}
