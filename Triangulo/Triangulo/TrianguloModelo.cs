using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class TrianguloModelo
    {
            
        private double baseTriangulo;
        private double alturaTriangulo;

        public TrianguloModelo()
        {
            this.baseTriangulo = 0;
            this.alturaTriangulo = 0;
        }

        public double GetBase()
        {
            return this.baseTriangulo;
        }

        public void SetBase(double bas)
        {
            this.baseTriangulo = bas;
        }

        public double GetAltura()
        {
            return this.alturaTriangulo;
        }

        public void SetAltura(double alt)
        {
            this.alturaTriangulo = alt;
        }

        public double AreaTriangulo()
        {
            return ((GetAltura() * GetBase()) / 2);
        }
    }
}
