using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObjetosTest_01
{
    public class Fraccion
    {
        private int numerador;

        public int Numerador
        {
            get
            {
                return numerador; 
            }
            set
            {
                numerador = value; 
            }
        }

        private int denominador;

        public int Denominador
        {
            get
            {
                return denominador;
            }
            set
            {
                denominador = value;
            }
        }

        public Fraccion(int n, int d)
        {
            numerador = n;
            denominador = d;
        }

        public Fraccion Sumar(Fraccion otra)
        {
            int denominadorComun = denominador * otra.denominador;
            int n1 = (denominadorComun / denominador) * numerador;
            int n2 = (denominadorComun / otra.denominador) * otra.denominador;
            Fraccion resultado = new Fraccion(n1 + n2, denominadorComun);
            return resultado;

        }

        public override string ToString()
        {
            return numerador + "/" + denominador;
        }

    }
}
