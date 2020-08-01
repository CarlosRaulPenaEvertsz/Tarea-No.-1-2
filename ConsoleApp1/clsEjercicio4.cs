using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No1_2
{
    class clsEjercicio4
    {
        public void Ejecuta()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 4");
            Console.WriteLine("Programa Ingreso Datos de Cuentas Corrientes");
            Console.WriteLine("---------------------------------------------\n\n");

            int ItemActual = 1;
            int NumeroCuenta = 0;
            decimal SaldoActual = 0.00M;
            decimal TotalSaldosAcreedores = 0;
            string Tipo="";
            

            List<string> ListadoCuentas = new List<string> ();

            Console.WriteLine("A continuacion debe entrar los datos de los clientes.\nPara Terminar, Digite un valor negativo en la Cuenta del Cliente.\n\n");

            // Ingreso de Datos (Hasta que la Cuenta Sea Negativa
            do
            {
                Console.WriteLine($"Entre No. Cuenta del Cliente [{ItemActual}]: ");
                if (int.TryParse(Console.ReadLine(), out NumeroCuenta) == true)
                {
                    if (NumeroCuenta > 0)
                    {
                        Console.WriteLine($"Entre el Saldo Actual de la Cuenta del Cliente[{ItemActual}]: ");
                        if (decimal.TryParse(Console.ReadLine(), out SaldoActual) == true)
                        {
                            //  Registrar Datos Cuenta
                            if (SaldoActual < 0)
                            {
                                Tipo = "Deudor";
                            }
                            else if (SaldoActual > 0)
                            {
                                Tipo = "Acreedor";
                                TotalSaldosAcreedores += SaldoActual;
                            }
                            else
                            {
                                Tipo = "Nulo";
                            }
                        }
                        ListadoCuentas.Add($"Cuenta:{NumeroCuenta}   Saldo Actual={SaldoActual.ToString("C")}   {Tipo}");
                        ItemActual++;
                    }
                }
                else
                {
                    Console.WriteLine("Error en Entrada, Intente Nuevamente");
                }
            } while (NumeroCuenta >= 0);


            // Generacion Reporte
            Console.WriteLine("\n\nRelación de Cuentas");
            Console.WriteLine("=====================");
            foreach (string Detalles in ListadoCuentas)
                {
                    Console.WriteLine(Detalles);
                }

             // Resumen Totales
             Console.WriteLine("---------------------");
             Console.WriteLine($"Total de los Saldos Acreedores = {TotalSaldosAcreedores}");

             Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
             Console.ReadKey();
        }


    }
}
