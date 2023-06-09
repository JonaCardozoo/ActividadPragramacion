using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad_parcial {
    internal class Program {
        static void Main(string[] args) 
        {

            promedio p = new promedio();

            double valor = 0;
            int op=0;

            do

            {

                Console.WriteLine("\t1- Agregar numero");
                Console.WriteLine("\t2- Calcular Promedio");
                Console.WriteLine("\t3- Salir");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (op)

                {

                    case 1:


                        Console.WriteLine("Ingrese los numeros (corte con -1)");
                        valor = Convert.ToDouble(Console.ReadLine());
                        p.IngresarNum(valor);



                        Console.Clear();


                        break;

                    case 2:



                        //p.CalcularPromedio(valor);
                        Console.WriteLine("El promedio es de: {0}", p.CalcularPromedio(valor));



                        break;


                    case 3:

                        
                        break;


                }


            } while (op != 3);
        }
    }
}
