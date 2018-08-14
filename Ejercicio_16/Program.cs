using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)  //Sherley Naomi Marcelino Mendoza.
        {
            //Variables.
            bool cliente = true;
            int cantidadCliente = 0;
            decimal descuentoTotal = 0, monto = 0;
            string leer = string.Empty;
            int edad = 0;

            Console.WriteLine("Nombre(s):   Sheley Naomi. ");         //Nombre.
            Console.WriteLine("===================================");
            Console.WriteLine("Apellido(s): Marcelino Mendoza ");     //Apellido.
            Console.WriteLine("===================================");
            Console.WriteLine("Matricula:   17-MIIN-1-123  ");        //Matricula.
            Console.WriteLine("===================================");
            Console.WriteLine("Seccion:     0463");                     //Sección.
            Console.WriteLine("===================================");
            Console.WriteLine("Materia:     Programacion Estructurada"); //Materia.
            Console.WriteLine("===================================");
            Console.WriteLine("\n\n");

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
                    Console.WriteLine("\n");
                    Console.WriteLine("\n--------------------Cierre de Caja-----------------\n\nLa Cantidad de cliente es: " + cantidadCliente);
                    Console.WriteLine("\n");
                    Console.WriteLine("El Valor Total es: " + descuentoTotal);
                    Console.WriteLine("\nFecha: " + DateTime.Now.ToString("dd/MM/yyyy"));
                    Console.WriteLine("\n");
                    Console.WriteLine("Nombre(s):   Sheley Naomi. ");         
                    Console.WriteLine("===================================");
                    Console.WriteLine("Apellido(s): Marcelino Mendoza ");     
                    Console.WriteLine("===================================");
                    Console.WriteLine("Matricula:   17-MIIN-1-123  ");        
                    Console.WriteLine("===================================");
                    Console.WriteLine("Seccion:     0463");                     
                    Console.WriteLine("===================================");
                    Console.WriteLine("Materia:     Programacion Estructurada"); 
                    Console.WriteLine("===================================");
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
