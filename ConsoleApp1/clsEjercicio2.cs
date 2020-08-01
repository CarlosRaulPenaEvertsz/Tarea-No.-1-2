using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_No1_2
{
    class clsEjercicio2
    {
        public void Ejecuta()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("Programa Cálculo Aumento Salario por Antiguedad");
            Console.WriteLine("-------------------------------------------------\n\n");

            decimal Sueldo = 0.00M;
            int Antiguedad = 0;

            Console.WriteLine("Entre el Sueldo:");
            if (decimal.TryParse(Console.ReadLine(), out Sueldo) == false) {
                Sueldo = 0.00M;
            }

            Console.WriteLine("Entre los Años de Antiguedad:");
            if (int.TryParse(Console.ReadLine(), out Antiguedad) == false)
            {
                Antiguedad = 0;
            }

            if ((Sueldo<500) && (Antiguedad>=10)) {
                Sueldo = Sueldo + (Sueldo * 0.2m);
            } else if ((Sueldo<500) && (Antiguedad<10))
            {
                Sueldo = Sueldo + (Sueldo * 0.05m);
            }

            Console.WriteLine("El Nuevo Sueldo es " + Sueldo.ToString("C"));
        
            Console.WriteLine("\n\nPresione Cualquier Tecla para Salir");
            Console.ReadKey();
        }
    }
}
