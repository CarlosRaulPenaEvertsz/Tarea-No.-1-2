using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No1_2
{
    class clsEjercicio1
    {

        public void Ejecuta()
        {
            int Numeros = 1;

            Console.Clear();
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Programa Imprime Mútiplos de 3 desde el 1 al 200");
            Console.WriteLine("-------------------------------------------------\n\n");

            Console.WriteLine("Los Múltiplos de 3 desde el 1 al 200 son:");
            while (Numeros <= 200)
            {
                if ((Numeros % 3) == 0)
                {
                    Console.Write("\t"+Numeros);
                }
                Numeros++;
            }

            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }
    }

}