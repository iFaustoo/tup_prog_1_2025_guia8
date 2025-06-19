using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    internal class Program
    {
        static int edad0;
        static int edad1;
        static int edad2;
        static int edad3;
        static double monto;
        static double porcentaje0;
        static double porcentaje1;
        static double porcentaje2;
        static double porcentaje3;
        static double monto0;
        static double monto1;
        static double monto2;
        static double monto3;

        static void RegistrarMontoARepartir(double monto)
        {
            Program.monto = monto;
        }

        static void RegistrarEdad(int edad, int nroNiña)
        {
            switch (nroNiña)
            {
                case 0: edad0 = edad;
                    break;
                case 1: edad1 = edad;
                    break;
                case 2: edad2 = edad;
                    break;
                case 3: edad3 = edad;
                    break;
            }
        }
        static void CalcularMontosYPorcentajesARepartir()
        {
            double edadTotal = edad0 + edad1 + edad2 + edad3;
            porcentaje0 = 1.0 * (edad0 / edadTotal * 100);
            porcentaje1 = 1.0 * (edad1 / edadTotal * 100);
            porcentaje2 = 1.0 * (edad2 / edadTotal * 100);
            porcentaje3 = 1.0 * (edad3 / edadTotal * 100);
            monto0 = monto * porcentaje0 / 100;
            monto1 = monto * porcentaje1 / 100;
            monto2 = monto * porcentaje2 / 100;
            monto3 = monto * porcentaje3 / 100;
        }
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Solicitar una opción dentro del menú");
            Console.WriteLine("1. Iniciar Monto a repartir");
            Console.WriteLine("2. Solicitar Edad por Niña");
            Console.WriteLine("3. Mostrar monto y porcentajes que corresponda a cada niña");
            Console.WriteLine("(otro). Salir");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        static void MostrarPantallaSolicitarMontoARepartir()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el monto a repartir entre las 4 niñas:");
            double montoARepartir = Convert.ToDouble(Console.ReadLine());
            RegistrarMontoARepartir(montoARepartir);
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaSolicitarEdadesNiñas()
        {
            Console.Clear();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese las edad de la niña número: " + (i + 1));
                int edad = Convert.ToInt32(Console.ReadLine());
                RegistrarEdad(edad, i);
            }
        }

        static void MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña()
        {
            Console.Clear();
            Console.WriteLine("Pantalla edad de cada niña junto con sus montos y porcentajes:");
            CalcularMontosYPorcentajesARepartir();
            Console.WriteLine($"Edad de la niña 1: {edad0}, monto: {monto0}, porcentaje: {porcentaje0}");
            Console.WriteLine($"Edad de la niña 2: {edad1}, monto: {monto1}, porcentaje: {porcentaje1}");
            Console.WriteLine($"Edad de la niña 3: {edad2}, monto: {monto2}, porcentaje: {porcentaje2}");
            Console.WriteLine($"Edad de la niña 4: {edad3}, monto: {monto3}, porcentaje: {porcentaje3}");
            Console.WriteLine("Presione cualquier tecla para volver al menú principal");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            bool menu = true;


            while (menu)
            {
                {
                    int op = MostrarPantallaSolicitarOpcionMenu();
                    switch (op)
                    {
                        case 1:
                            MostrarPantallaSolicitarMontoARepartir();
                            break;
                        case 2:
                            MostrarPantallaSolicitarEdadesNiñas();
                            break;
                        case 3:
                            MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña();
                            break;
                        default: menu = false;break;
                    }
                }   
            }
        }
    }
}
