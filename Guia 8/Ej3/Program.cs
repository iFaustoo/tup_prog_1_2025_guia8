using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Ej3
{
    internal class Program
    {

        static string nombre0;
        static int numeroLibreta0;
        static string nombre1;
        static int numeroLibreta1;
        static string nombre2;
        static int numeroLibreta2;
        static int orden;

        static void RegistrarNombreYNumeroLibreta(string nombre, int numeroLibreta)
        {
            if (orden == 0)
            {
                nombre0 = nombre1;
                numeroLibreta0 = numeroLibreta;
            }
            else if (orden == 1)
            {
                if (numeroLibreta < numeroLibreta0)
                {
                    nombre1 = nombre0;
                    numeroLibreta1 = numeroLibreta0;
                    nombre0 = nombre;
                    numeroLibreta0 = numeroLibreta;
                }
                else
                {
                    nombre1 = nombre;
                    numeroLibreta = numeroLibreta0;
                }
            }
            else if (orden == 2)
            {
                if (numeroLibreta < numeroLibreta0)
                {
                    nombre2 = nombre1;
                    numeroLibreta2 = numeroLibreta1;
                    nombre1 = nombre0;
                    numeroLibreta1 = numeroLibreta0;
                    nombre0 = nombre;
                    numeroLibreta0 = numeroLibreta;
                }
                if (numeroLibreta < numeroLibreta1)
                {
                    nombre2 = nombre1;
                    numeroLibreta2 = numeroLibreta1;
                    nombre1 = nombre;
                    numeroLibreta1 = numeroLibreta;
                }
                else
                {
                    nombre2 = nombre;
                    numeroLibreta2 = numeroLibreta;
                }
            }
            orden++;
        }

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Pantalla menú");
            Console.WriteLine("1. Registrar las notas de los 3 alumnos");
            Console.WriteLine("2. Mostrar lista ordenada");
            Console.WriteLine("3. Presione cualquier tecla para salir");
            int op = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            return op;
        }

        static void MostrarPantallaSolicitarAlumnos()
        {
            Console.Clear();
            Console.WriteLine("Ingrese los nombres y números de libreta de los 3 alumnos");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Alumno " + (i + 1) + ", ingrese primero el nombre y después su número de libreta");
                string nombre = Console.ReadLine();
                int nota = Convert.ToInt32(Console.ReadLine());
                RegistrarNombreYNumeroLibreta(nombre, nota);
            }
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaMostrarListaOrdenada()
        {
            Console.Clear();
            Console.WriteLine("Pantalla datos finales");
            Console.WriteLine($"Alumno: {nombre0}, número de libreta: {numeroLibreta0}");
            Console.WriteLine($"Alumno: {nombre1}, número de libreta: {numeroLibreta1}");
            Console.WriteLine($"Alumno: {nombre2}, número de libreta: {numeroLibreta2}");

            Console.WriteLine("Presione cualquier tecla");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int op = MostrarPantallaSolicitarOpcionMenu();
            while (op != -1)
            {
                switch (op)
                { 
                case 1:
                    MostrarPantallaSolicitarAlumnos();
                    break;
                case 2:
                    MostrarPantallaMostrarListaOrdenada();
                    break;
                default:
                    op = -1;
                    break;
                }

                if (op != -1)
                {
                    op = MostrarPantallaSolicitarOpcionMenu();
                }
            }
        }
    }
}
