using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No1_2
{
    class clsEjercicio3
    {
        public void Ejecuta()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 3");
            Console.WriteLine("Programa Cálculo Ingreso y Análisis Números");
            Console.WriteLine("---------------------------------------------\n\n");
            int i = 0;
            int Cantidad = 0;
            int NumeroActual = 0;

            int CantidadNumerosPositivos = 0;
            int CantidadNumerosNegativos = 0;
            int CantidadNumerosPares = 0;
            int CantidadNumerosImpares = 0;

            Console.WriteLine("Cuantos Números Vamos a Procesar?");

            if (int.TryParse(Console.ReadLine(), out Cantidad) == false)
            {
                Cantidad = 0;
            }

            while (i < Cantidad) {
                Console.WriteLine($"Entre el Valor Para la Entrada No.({i+1})");
                if (int.TryParse(Console.ReadLine(),out NumeroActual)==true)
                {
                    if (NumeroActual % 2==0){
                        CantidadNumerosPares++;
                    } else {
                        CantidadNumerosImpares++;
                    }
                    if (NumeroActual>=0)
                    {
                        CantidadNumerosPositivos++;
                    } else
                    {
                        CantidadNumerosNegativos++;
                    }
                    i++;
                }
            }

            Console.WriteLine($"\n\nTotal de Numeros Pares = {CantidadNumerosPares}");
            Console.WriteLine($"Total de Numeros ImPares = {CantidadNumerosImpares}");
            Console.WriteLine($"Total de Numeros Positivos = {CantidadNumerosPositivos}");
            Console.WriteLine($"Total de Numeros Negativos = {CantidadNumerosNegativos}");

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }

    }
}
