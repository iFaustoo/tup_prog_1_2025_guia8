using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ej4
{
    internal class Program
    {

        static string jugador1;
        static int setsGanados1;
        static string jugador2;
        static int setsgGanados2;


        static void RegistrarJugadores(string nombre1, string nombre2)
        {
            nombre1 = jugador1;
            nombre2 = jugador2;
            setsGanados1 = 0;
            setsgGanados2 = 0;
        }

        static void RegistrarResultadoSet(int resultado1, int resultado2)
        {
            setsGanados1 += resultado1;
            setsGanados1 += resultado2;
        }

        static string DeterminarGanador()
        {
            if (setsGanados1 > setsGanados2)    
            {
                return jugador1;
            }
            else if (setGanados1 < setsgGanados2)
            {
                return jugador2;
            }
            else
            {
                return "Empate!";
            }
        }

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Menú");
            Console.WriteLine("1. Registrar los nombres de los dos jugadpres");
            Console.WriteLine("2. Registrar los resultados de cada set de los jugadores");
            Console.WriteLine("3. Mostrar el ganador");
            Console.WriteLine("Seleccione cualquier otra tecla para salir");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        static void MostrarPantallaSolicitarNombreJugadores()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del primer jugador");
            string jugador1 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del segundo jugador");
            string jugador2 = Console.ReadLine();
            RegistrarJugadores(jugador1, jugador2);

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaSolicitarResultadoSet()
        {
            Console.Clear();
            Console.WriteLine("Ingrese los resultados del set del primer jugador");
            int set1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese los resultados del set del segundo jugador");
            int set2 = Convert.ToInt32(Console.ReadLine());
            RegistrarResultadoSet(set1, set2);

            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaGanador()
        {
            Console.Clear();
            Console.WriteLine("El ganador es: ");
            string ganador = DeterminarGanador();
            Console.WriteLine($"{ganador}");

            Console.WriteLine("Presione una tecla para continuar");
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
                        MostrarPantallaSolicitarNombreJugadores();
                        break;
                    case 2:
                        MostrarPantallaSolicitarResultadoSet();
                        break;
                    case 3:
                        MostrarPantallaGanador();
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
