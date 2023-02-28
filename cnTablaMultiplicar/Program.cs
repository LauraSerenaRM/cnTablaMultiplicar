using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnTablaMultiplicar
{/// <summary>
/// Nombre: Laura Serena Rivera Mejía
/// Fecha: 24-02-2023
/// Descripción: Este programa solicita un número entero a multiplicar, si se ingresa el -1 se finaliza 
/// el programa y no se ejecuta.
    internal class ClsTabla
    {   
        //Declaración de variables.
        int NumeroEntero;

        static void Main(string[] args)
        {
            //Se crea un objeto de la Clase Tabla
            ClsTabla oTablaMultiplicar = new ClsTabla();
            //Se llaman los métodos a partir del objeto tabla multiplicar
            oTablaMultiplicar.SolicitarDatos();
            //Instrucción de espera al final de toda la ejecución.
            Console.ReadLine();
        }

        //Método único
        public void SolicitarDatos()
        {
            do
            {
                Console.WriteLine("Ingrese el número a multiplicar");
                NumeroEntero = int.Parse(Console.ReadLine());
               

                if (NumeroEntero != -1)
                {
                    Console.WriteLine("Su tabla es: ");

                    for (int i = 0; i <= 10; i++)
                    {
                       
                        Console.WriteLine(NumeroEntero + "x" + i + "=" + NumeroEntero * i);
                    }
                }

            } while (NumeroEntero != -1);

            Console.WriteLine("Ingresaste -1. No se ejecutará el programa. Presiona cualquier tecla para salir.");

        }


    }
}
