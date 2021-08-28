using System;
using UtilityLibraries;

namespace Showcase
{
    class Program
    {
       
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Entrez une première valeur : ");
                int input1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Entrez une deuxième valeur : ");
                int input2 = int.Parse(Console.ReadLine());
                StringLibrary.CalCulator sq = new StringLibrary.CalCulator();
                Console.WriteLine("Addition : " + sq.Add(input1, input2));
                Console.WriteLine("Soustraction : " + sq.Subtract(input1, input2));
                Console.WriteLine("Multiplication : " + sq.Multiply(input1, input2));
                Console.WriteLine("Division : " + sq.Division(input1, input2));
                Console.ReadLine();
            }
        }
    }
}
