using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Ej1
{
    internal class Program
    {
        static int acumulador;
        static int contador;
        static int maximo;
        static int minimo;

        static void RegistrarValor(int valor)
        {
            acumulador += valor;
            contador++;

                if (contador == 1 || valor > maximo)
            {
                maximo = valor;
            }
            if (contador == 1 || valor < minimo)
            {
                minimo = valor;
            }
        }

        static double CalcularPromedio()
        {
            double promedio = 0;
            if (contador > 0)
            {
                promedio = 1.0 * (acumulador / contador);
            }
            return promedio;
        }

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Procesar un solo número");
            Console.WriteLine("2. Procesar varios números");
            Console.WriteLine("3. Mostrar máximo y mínimo");
            Console.WriteLine("4. Mostrar promedio");
            Console.WriteLine("5. Mostrar cantidad de números ingresados");
            Console.WriteLine("6. Reiniciar variables");
            Console.WriteLine("(Presione cualquier tecla). Salir");
            int rta = Convert.ToInt32(Console.ReadLine());
            return rta;
        }

        static void MostrarIniciarVariable()
        {
            Console.Clear();
            Console.WriteLine("Reiniciando variables");
            acumulador = 0;
            contador = 0;
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaSolicitarNumero()
        {
            Console.Clear();
            Console.WriteLine("Ingrese un número:");
            int valor = Convert.ToInt32(Console.ReadLine());
            RegistrarValor(valor);
        }
        static void MostrarPantallaSolicitarVariosNumeros()
        {
            Console.Clear();
            Console.WriteLine("Ingrese cuántos numeros quiere ingresar");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                MostrarPantallaSolicitarNumero();
            }
        }

        static void MostrarPantallaMaximoYMinimo()
        {
            Console.Clear();
            Console.WriteLine("Pantalla número máximo y número mínimo");
            Console.WriteLine($"Máximo: {maximo}");
            Console.WriteLine($"Mínimo: {minimo}");
            Console.WriteLine("Presione una tecla para volver al menú");
            Console.ReadKey();
        }
        static void MostrarPantallaCalcularYMostrarPromedio()
        {
            Console.Clear();
            Console.WriteLine("Pantalla de promedio");
            if (contador > 0)
            {
                Console.WriteLine("Promedio: " + CalcularPromedio());
            }
            else
            {
                Console.WriteLine("Promedio: No se han ingresado números");
            }
            Console.WriteLine("Presione una tecla para volver al menú");
            Console.ReadKey();
        }

        static void MostrarPantallaCantidad()
        {
            Console.Clear();
            Console.WriteLine("Pantalla de cantidad de valores procesados");
            if (contador > 0)
            {
                Console.WriteLine("Cantidad de valores procesados: "  + contador);
            }
            else
            {
                Console.WriteLine("Cantidad de valores procesados: No se han ingresado números");
            }
            Console.WriteLine("Presione cualquier tecla para volver al menú");
            Console.ReadKey();
        }


        static void Main(string[] args)
        {

            int op = MostrarPantallaSolicitarOpcionMenu();

            while ( op != 0 ) 
            {
                switch(op)
                {
                    case 1:
                        MostrarPantallaSolicitarNumero();
                        break;
                    case 2:
                        MostrarPantallaSolicitarVariosNumeros();
                        break;
                    case 3:
                        MostrarPantallaMaximoYMinimo();
                        break;
                    case 4:
                        MostrarPantallaCalcularYMostrarPromedio();
                        break;
                    case 5:
                        MostrarPantallaCantidad();
                        break;
                    case 6:
                        MostrarIniciarVariable();
                        break;
                    default:
                        Console.WriteLine("Proceso terminado.");
                        break;
                }

                op = MostrarPantallaSolicitarOpcionMenu();
            }
        }
    }
}
