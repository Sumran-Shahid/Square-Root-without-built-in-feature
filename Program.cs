using System;

// this program can find the square root of a number without using any library or a square root built in feature
// this method uses the Newton-Raphson Algorithm of approximation to calculate the square root of a number

namespace square_root
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the square root of any number. Enter the number: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double x_n = x;
            double x_n_plus_1 = new double();
            for (int i = 0; i < 50; i++) {
                x_n_plus_1 = (x_n + (x / x_n)) / 2;
                if (Math.Abs(x_n_plus_1 - x_n) < 0.000001) {
                    break;
                }
                x_n = x_n_plus_1;
            }
            Console.WriteLine(x_n_plus_1);
        }

        // static double root(double x, double x_n) {
        //     double x_n_plus_1 = new double();
        //     x_n_plus_1 = (x_n + (x / x_n)) / 2;
        //     return x_n_plus_1;
        // }
    }
}
