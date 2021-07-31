using System;
namespace primeiro
{
    public class Triangulo
    {
        public double A, B, C;

      public double  CalcTriangle( ) 
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
              
        }
    }
}
