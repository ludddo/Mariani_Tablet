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

                Console.WriteLine("Inserire la durata del " + i + " tablet");
                durata[i] = double.Parse(Console.ReadLine());
            }
            
            Tablet tablet1 = new Tablet(marca[0], velocita[0], dimensione[0], durata[0]);
            Tablet tablet2 = new Tablet(marca[1], velocita[1], dimensione[1], durata[1]);
            Tablet tablet3 = new Tablet(marca[2], velocita[2], dimensione[2], durata[2]);
            Tablet tablet4 = new Tablet(marca[3], velocita[3], dimensione[3], durata[3]);
            Tablet tablet5 = new Tablet(marca[4], velocita[4], dimensione[4], durata[4]);

            double[] punteggioMedio = new double[5];

            punteggioMedio[0] = (tablet1.Punteggio()[0] + tablet1.Punteggio()[1] + tablet1.Punteggio()[2]) / 3;
            punteggioMedio[1] = (tablet2.Punteggio()[0] + tablet2.Punteggio()[1] + tablet2.Punteggio()[2]) / 3;
            punteggioMedio[2] = (tablet3.Punteggio()[0] + tablet3.Punteggio()[1] + tablet3.Punteggio()[2]) / 3;
            punteggioMedio[3] = (tablet4.Punteggio()[0] + tablet4.Punteggio()[1] + tablet4.Punteggio()[2]) / 3;
            punteggioMedio[4] = (tablet5.Punteggio()[0] + tablet5.Punteggio()[1] + tablet5.Punteggio()[2]) / 3;

            Array.Sort(punteggioMedio);
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(punteggioMedio[i]);
            }
        }
    }
}
