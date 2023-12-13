using System;

namespace OOPLaba4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NormalizedVector vec1 = new NormalizedVector();
            NormalizedVector vec2 = new NormalizedVector(3, 8);

            NormalizedVector vec3 = vec1 * vec2;
            vec1.Print();
            vec2.Print();
            vec3.Print();
            Console.ReadLine();

        }
        class NormalizedVector
        {
            private double x;
            private double y;
            private double modal;
            private double scalar;

            public double X
            {
                get { return x; }
                set { x = value; }
            }

            public double Y
            {
                get { return y; }
                set { y = value; }
            }


            public NormalizedVector()
            {
                x = 1.0;
                y = scalar = 0;
                modal = NormalVector();
            }

            public NormalizedVector(double x, double y)
            {
                if (x >= 0.5)
                {
                    this.x = x;
                }
                else
                {
                    this.x = 1;
                }

                if (y >= 0.5)
                {
                    this.y = y;
                }
                else
                {
                    this.y = 1;
                }

            }

            private double NormalVector()
            {
                double leght = Math.Sqrt(x * x + y * y);

                leght = 1 / leght;

                x *= leght;

                y *= leght;

                modal = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

                return modal;
            }

            public override string ToString()
            {
                return "X = 0.0, Y = 0.0";
            }

            public static NormalizedVector operator *(NormalizedVector a, NormalizedVector b)
            {
                var temp = new NormalizedVector();

                temp.x = a.x * b.x;
                temp.y = a.y * b.y;
                temp.scalar = temp.x + temp.y;
                return temp;
            }

            public void Print()
            {
                Console.WriteLine($"X = {x}, Y = {y}, Scalar = {scalar}");
            }

        }
    }

}
