using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7
{
    internal class Program
    {

        static void InicializarVariables()
        {
            cantidad1 = 0;
            cantidad2 = 0;
            cantidad3 = 0;
            cantidad4 = 0;
            cantidad5 = 0;
            numeroTransaccionMayor = 0;
            montoTransaccionMayor = 0;

            contadorDeTransacciones = 0;

            porcentajeCantidadRubro1 = 0;
            porcentajeCantidadRubro2 = 0;
            porcentajeCantidadRubro3 = 0;
            porcentajeCantidadRubro4 = 0;
            porcentajeCantidadRubro5 = 0;

            recaudacionTotal = 0;
        }

        static void EvaluarTransaccionPuntoDeVenta(int nroTransaccion, int rubro, int cantidad, double monto)
        {
            switch (rubro)
            {
                case 1:
                    cantidad1 += cantidad;
                    break;
                case 2:
                    cantidad2 += cantidad;
                    break;
                case 3:
                    cantidad3 += cantidad;
                    break;
                case 4:
                    cantidad4 += cantidad;
                    break;
                case 5:
                    cantidad5 += cantidad;
                    break;
                default:
                    break;
            }
            recaudacionTotal += monto;

            if (contadorDeTransacciones == 0 || monto > montoTransaccionMayor)
            {
                numeroTransaccionMayor = nroTransaccion;
                montoTransaccionMayor = monto;
            }
        }
        static void CalcularPorcentajesCantidadVentasPorRubro()
        {
            int CantidadTotal = cantidad1 + cantidad2 + cantidad3 + cantidad4 + cantidad5;

            porcentajeCantidadRubro1 = 0;
            porcentajeCantidadRubro2 = 0;
            porcentajeCantidadRubro3 = 0;
            porcentajeCantidadRubro4 = 0;
            porcentajeCantidadRubro5 = 0;

            if (CantidadTotal > 0)
            {
                porcentajeCantidadRubro1 = 100.0 * cantidad1 / CantidadTotal;
                porcentajeCantidadRubro2 = 100.0 * cantidad2 / CantidadTotal;
                porcentajeCantidadRubro3 = 100.0 * cantidad3 / CantidadTotal;
                porcentajeCantidadRubro4 = 100.0 * cantidad4 / CantidadTotal;
                porcentajeCantidadRubro5 = 100.0 * cantidad5 / CantidadTotal;
            }
        }

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Ingresar un resumen de venta");
            Console.WriteLine("2. Mostrar número de transacción registrado con el mayor monto total");
            Console.WriteLine("3. Mostrar porcentaje de cantidad por rubros");
            Console.WriteLine("4. Mostrar la recaudación total");

            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        static void MostrarPantallaRegistrarTransaccion()
        {
            Console.Clear();
            Console.WriteLine("Registre la transacción de venta. \n\n");

            Console.WriteLine("\nNumero de transacción: \n");
            int nro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n\nNumero de rubro (de 1 a 5): \n");
            int rubro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n\nCantidad de productos: \n");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n\nMonto total de la transacción: \n");
            double monto = Convert.ToDouble(Console.ReadLine());

            EvaluarTransaccionPuntoDeVenta(nro, rubro, cantidad, monto);

            Console.WriteLine("\n\n\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaTransaccionMayorMonto()
        {
            Console.Clear();
            Console.WriteLine("Transaacción con mayor monto en ventas:");
            Console.WriteLine($"Transacción número: {numeroTransaccionMayor}");
            Console.WriteLine($"Total monto: {montoTransaccionMayor}");
            Console.WriteLine($@"Transacción con mayor monto en ventas");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaPorcentajeDeCantidadesPorRubro()
        {
            Console.Clear();
            CalcularPorcentajesCantidadVentasPorRubro();

            Console.WriteLine("Porcentaje de venta por rubro");
            Console.WriteLine($"Primer rubro: {porcentajeCantidadRubro1}");
            Console.WriteLine($"Segundo rubro: {porcentajeCantidadRubro2}");
            Console.WriteLine($"Tercer rubro: {porcentajeCantidadRubro3}");
            Console.WriteLine($"Cuarto rubro: {porcentajeCantidadRubro4}");
            Console.WriteLine($"Quinto rubro: {porcentajeCantidadRubro5}");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaMontoRecaudadoTotal()
        {
            Console.Clear();
            Console.WriteLine("Monto total recaudado:");
            Console.WriteLine($"Recaudación total: {recaudacionTotal}");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {

            InicializarVariables();

            int op = MostrarPantallaSolicitarOpcionMenu();

            while (op != -1)
            {
                switch (op)
                {
                    case 1:
                        MostrarPantallaRegistrarTransaccion();
                        break;
                    case 2:
                        MostrarPantallaTransaccionMayorMonto();
                        break;
                    case 3:
                        MostrarPantallaPorcentajeDeCantidadesPorRubro();
                        break;
                    case 4:
                        MostrarPantallaMontoRecaudadoTotal();
                        break;
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
