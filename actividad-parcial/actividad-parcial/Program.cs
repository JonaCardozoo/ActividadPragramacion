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

            double num = 0;
            int op=0;
            while(op != -1) 
                
            {
                
                Console.WriteLine("\t1- Agregar numero");
                Console.WriteLine("\t2- Calcular Promedio");
                Console.WriteLine("\t3- Salir");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();    
                
                switch(op) {

                case 1:
                    
                    

                    while(num != -1) 
                        
                    {
                        
                        Console.WriteLine("Ingrese los numeros (corte con -1)");
                        num = Convert.ToDouble(Console.ReadLine());
                        p.IngresarNum(num);
                        p.promedioo(num);
                    }

                    
                    break;

                case 2:

                    

                    p.CalcularPromedio(num);
                    Console.WriteLine("El promedio es de: {0:f2}", p.CalcularPromedio(num));

                    break;
                
                
                }
                
                
                




            }
        }
    }
}
