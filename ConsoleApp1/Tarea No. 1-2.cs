using System;

namespace Tarea_No1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu Tarea No. 1-2
            //Ejercicios Propuestos en la Guía Práctica No. 2(Tarea No. 1 - 2)
            //El menu contiene los ejercicios en el mismo orden de la Guia.
            
            int intSeleccion=1;

            while (intSeleccion != 99)
            {
                Console.Clear();
                Console.WriteLine("Menu Tarea No. 1-2");
                Console.WriteLine("------------------");

                // Menu de ejercicios
                Console.WriteLine("1-Programa Imprima Mútiplos de 3 desde el 1 al 200");
                Console.WriteLine("2-Programa Cálculo Aumento Salario por Antiguedad");
                Console.WriteLine("3-Programa Cálculo Ingreso y Análisis Números");
                Console.WriteLine("4-Programa Ingreso Datos de Cuentas Corrientes");
                // 
                Console.Write("***Seleccione el Ejercicio a Ejecutar y Presione ENTER. (99-Salir)");

                if ( int.TryParse(Console.ReadLine(),out intSeleccion) == false)
                {
                    intSeleccion = 0;
                }

                //*********************************************
                // Seleccion de ejercicios
                //********************************************
                switch (intSeleccion)
                {
                    case 1: // 1-Programa Imprima Mútiplos de 3 desde el 1 al 200
                        clsEjercicio1 Ejercicio1 = new clsEjercicio1();
                        Ejercicio1.Ejecuta();
                        break;

                    case 2: // 2-Programa Cálculo Aumento Salario por Antiguedad
                        clsEjercicio2 Ejercicio2 = new clsEjercicio2();
                        Ejercicio2.Ejecuta();
                        break;

                    case 3: // 3-Programa Cálculo Ingreso y Análisis Números
                        clsEjercicio3 Ejercicio3 = new clsEjercicio3();
                        Ejercicio3.Ejecuta();
                        break;
                    case 4: // 4-Programa Ingreso Datos de Cuentas Corrientes
                        clsEjercicio4 Ejercicio4 = new clsEjercicio4();
                        Ejercicio4.Ejecuta();
                        break;

                    default:
                        Console.WriteLine("Default case");
                        break;
                }

            }
            Console.Clear();
            Console.WriteLine("Bye...");





        }
    }
}
