using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CribleEratosthene;

namespace Computation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crible d'Eratosthène
            /*Console.WriteLine("Veuillez entre votre nombre n.");
            String inputString = Console.ReadLine();
            int inputInteger;
            bool success = int.TryParse(inputString, out inputInteger);
            if (success)
            {
                Console.WriteLine("Les nombres premiers compris entre 0 et n = " + inputInteger + " sont : ");
                CribleEratosthene.Program.display(CribleEratosthene.Program.cribleEratosthene(inputInteger));
            }
            else
            {
                Console.WriteLine("Un problème est survenue, vous devez entre Veuillez entre votre nombre n.");

            }
            Console.ReadLine();*/

            //Matrix
            double[] d1 = { 1, 2 };
            double[] d2 = { 4, 5};
            double[] d3 = { 3, 9};

            double[][] data = {
                d1,
                d2
            };

            MatrixDouble A = new MatrixDouble(data);
            A.displayMatrix();
            Console.ReadLine();
        }
    }
}
