using System;
namespace primeiro
{
    public class Retangulo
    {
        public double width;
        public double height;

        public double areaRetangulo() {
            return width * height;
        }

        public double perimetro() {
            return (width * 2) + (height * 2);
        }

        public double diagonal() {
            double x = Math.Pow(width, 2) + Math.Pow(height, 2);
            return Math.Sqrt(x);
        }

        public override string ToString()
        {
            return $"A área do retângulo é: {areaRetangulo():f2} " +
                $" O perímetro do retângulo é: {perimetro():f2} " +
                $"A diagonal do retângulo é: {diagonal():f2} ";
        }
    }
}
