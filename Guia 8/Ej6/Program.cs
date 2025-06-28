using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    internal class Program
    {

        static int indecisos;
        static int negativos;
        static int positivos;
        static double porcentajeIndecisos;
        static double porcentajeNegativos;
        static double porcentajePositivos;

        static void RegistrarOpinion(int opinion)
        {
            switch (opinion)
            {
                case 1:
                    negativos++;
                    break;
                case 2:
                    positivos++;
                    break;
                default:
                    indecisos++;
                    break;
            }
        }
        static void ProcesarEncuesta()
        {
            double total = indecisos + negativos + positivos;

            if (positivos > 0)
            {
                porcentajeIndecisos = 100.0 * indecisos / total;
                porcentajeNegativos = 100.0 * negativos / total;
                porcentajePositivos = 100.0 * positivos / total;
            }
        }

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese las siguiente opciones:\n\n");
            Console.WriteLine("1- Registrar opinión");
            Console.WriteLine("2- Procesar y mostrar resultados encuesta");
            Console.WriteLine("(otro)- Salir.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void MostrarPantallaRegistrarEncuesta()
        {
            Console.Clear();
            Console.WriteLine("Determinar cantidad de días del mes \n\n");

            Console.WriteLine("Ingrese la opinion ((1)-negativo-(2) positivo-(otro) indeciso\n");
            int opinion = Convert.ToInt32(Console.ReadLine());

            RegistrarOpinion(opinion);

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }
        static void MostrarPantallaProcesarMostrarResultadosEncuesta()
        {
            Console.Clear();
            Console.WriteLine("Resultados encuesta. \n\n");

            ProcesarEncuesta();

            Console.WriteLine($"Positivos: {porcentajePositivos:f2}%");
            Console.WriteLine($"Negativos: {porcentajeNegativos:f2}%");
            Console.WriteLine($"Indecisos: {porcentajeIndecisos:f2}%");

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
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
                        MostrarPantallaRegistrarEncuesta();
                        break;
                    case 2:
                        MostrarPantallaProcesarMostrarResultadosEncuesta();
                        break;
                    default:
                        op = -1;
                        break;
                }

                if (op != -1)
                    op = MostrarPantallaSolicitarOpcionMenu();
            }

        }
    }
}
