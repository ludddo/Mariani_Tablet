using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariani_Tablet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] marca = new string[5];
            double[] velocita = new double[5];
            int[] dimensione = new int[5];
            double[] durata = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Inserire la marca del " + i + " tablet");
                marca[i] = Console.ReadLine();

                Console.WriteLine("Inserire la velocita del " + i + " tablet");
                velocita[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Inserire la dimensione del " + i + " tablet");
                dimensione[i] = int.Parse(Console.ReadLine());

                
            }
         
            
        }
    }
}
