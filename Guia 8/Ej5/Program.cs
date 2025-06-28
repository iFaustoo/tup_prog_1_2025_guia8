using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    internal class Program
    {

        static int año;
        static string mess = "";
        static int dias = 0;

        static int DeterminarLosDiasDelMes(int mes, int año)
        {
            int dias;

            bool esPar = mes % 2 == 0;

            bool esPrimeraMitad = mes <= 6;

            if (esPrimeraMitad)
            {
                if (esPar)
                {
                    if (mes == 2)
                    {
                        if (DeterminarSiEsBisiesto(año))
                        {
                            dias = 29;
                        }
                        else
                        {
                            dias = 28;
                        }
                    }
                    else
                    {
                        return 30;
                    }
                }
                else
                {
                    return 30;
                }
            }
            else
            {
                if (esPar)
                {
                    dias = 31;
                }
                else
                {
                    dias = 30;
                }
            }

            return dias;
        }

        static bool DeterminarSiEsBisiesto(int año)
        {
            bool esBisiesto = false;

            if (año % 4 == 0)
            {
                if (año % 100 != 0 || año % 400 == 0)
                {
                    esBisiesto = true;
                }
                else
                {
                    esBisiesto = false;
                }
            }
            else
            {
                esBisiesto = false;
            }
            return esBisiesto;
        }

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Determinar cantidad de días del mes");
            Console.WriteLine("2. Verificar si el año es bisiesto");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;

        }

        static void MostrarPantallaSolicitarMesAñoYDeterminarDias()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el número de un mes:");
            int mes = Console.ReadLine().ToLower();
            Console.WriteLine("Ingrese un año:");
            int año = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n\nLa cantidad de días del més ({mes}) es: \n\t\t\t{cantidadDias}\n\n\n");
            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }
        static void MostrarPantallaVerificarSiElAñoEsBisiesto()
        {
            Console.Clear();
            Console.WriteLine("Determinar si el año es bisiesto. \n\n");

            Console.WriteLine("\nIngrese el año:\n");
            int año = Convert.ToInt32(Console.ReadLine());

            if (DeterminarSiEsBisiesto(año))
            {
                Console.WriteLine("El año es bisiesto");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
            }

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
                        MostrarPantallaSolicitarMesAñoYDeterminarDias();
                        break;
                    case 2:
                        MostrarPantallaVerificarSiElAñoEsBisiesto();
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
