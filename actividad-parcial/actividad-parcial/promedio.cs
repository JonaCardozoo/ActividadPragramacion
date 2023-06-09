using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad_parcial {
    internal class promedio {

        private double[] valores;
        //public double num;
        int contador;
        private double total;


        public promedio()
        {
            valores = new double[100];
            contador = 0;

        }

        public void IngresarNum(double valor) {

            total += valor;
            valores[contador++] = valor;
            
        }

        public double CalcularPromedio(double valor)
        {

            double total = 0;
            for (int n = 0; n < contador; n++)
            {

                total += valores[n];
            } 

            double promedio = 0;

            if (contador > 0) 
                
            {
                promedio = total / contador;
               
            } 
             return promedio;
        }




    }
}
