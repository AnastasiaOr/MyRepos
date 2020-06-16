using System;


namespace AreaLibrary
{
    public class FigureArea
    {
       
        public double Area(double r)
        {
            double S = Math.Pow(r, 2) * Math.PI;
            return (S);
        }
        public double Area(double a, double b, double c)
        {
            double S;
            if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))//проверка по т Пифагора
            {
                Console.WriteLine("Треугольник прямоугольный");
                S = 0.5 * a * b;
                return (S);
            }
            else
            {
                double P = (a + b + c) / 2;
                S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
                return (S);
            }
        }
    }
}
