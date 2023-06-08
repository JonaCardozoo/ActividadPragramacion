using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad_parcial {
    internal class promedio {


        public double num;
        public double contador;
        public double acum;

        

        public void IngresarNum(double num) {

            this.num = num;
            
        }


        
        public double CalcularPromedio(double num) 
        {

            
            return acum / contador;


        }


        public void promedioo(double num) {


            if(num > 0) {

                contador++;
                acum += num;

            }

        }

    }
}
