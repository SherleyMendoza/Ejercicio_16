using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables.
            bool cliente = true;
            int cantidadCliente = 0;
            decimal descuentoTotal = 0, monto = 0;
            string leer = string.Empty;
            int edad = 0;


            Console.WriteLine("Ingrese el valor de la boleta: "); //Entrada.
            monto = Convert.ToDecimal(Console.ReadLine());

            //Bucle.
            while (cliente == true)
            {

                Console.Clear();
                Console.WriteLine("Presione la tecla: \n N: Para Registrar otra Venta.\n C: Cierre de Caja. \n S: Salir."); //Menu.
                leer = Console.ReadLine();


                //Condiciones.
                if (leer == "N" || leer == "n")
                {
                    Console.WriteLine("Ingrese la edad: "); //Entrada.
                    edad = Convert.ToInt32(Console.ReadLine());

                    if (edad >= 5)
                    {
                        if (Convert.ToInt32(edad) >= 5 && Convert.ToInt32(edad) <= 14)
                        {
                            descuentoTotal += Convert.ToDecimal(monto) * 35 / 100;
                        }
                        else if (Convert.ToInt32(edad) >= 15 && Convert.ToInt32(edad) <= 19)
                        {
                            descuentoTotal += Convert.ToDecimal(monto) * 25 / 100;
                        }
                        else if (Convert.ToInt32(edad) >= 20 && Convert.ToInt32(edad) <= 45)
                        {
                            descuentoTotal += Convert.ToDecimal(monto) * 10 / 100;
                        }
                        else if (Convert.ToInt32(edad) >= 46 && Convert.ToInt32(edad) <= 65)
                        {
                            descuentoTotal += Convert.ToDecimal(monto) * 25 / 100;
                        }
                        else if (Convert.ToInt32(edad) >= 66)
                        {
                            descuentoTotal += Convert.ToDecimal(monto) * 35 / 100;
                        }
                        cantidadCliente++;
                    }
                    else
                    {
                        Console.WriteLine("La edad es menor a 5:");
                        Console.ReadKey();
                    }
                }
                else if (leer == "c" || leer == "C")
                {
                    Console.Clear();
                    Console.WriteLine("\n--------------------Cierre de Caja-----------------\nLa Cantidad de cliente es: " + cantidadCliente);
                    Console.WriteLine("El Valor Total es: " + descuentoTotal);
                    Console.WriteLine("\nFecha: " + DateTime.Now.ToString("dd/MM/yyyy"));
                    Console.WriteLine("Sherley Mendoza."); //Nombre.
                    Console.ReadKey();
                    cliente = true;
                }
                else
                {
                    Environment.Exit(0); //Salida.
                }
            }

            //////////fin
        }
    }
}
