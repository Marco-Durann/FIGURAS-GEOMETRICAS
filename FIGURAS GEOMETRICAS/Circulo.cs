using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURAS_GEOMETRICAS
{
    public class Circulo : Figura
    {
        double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * (radio * radio);
        }

        public override double CalcularVolumen()
        {
            return 0; // Los círculos no tienen volumen
        }
    }
    // internal class Circulo
    // {
    //}
}
