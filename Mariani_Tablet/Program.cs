using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

                Console.Clear();
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


            int indirizzoMin = 0, indirizzoMax = 0;
            double valMax = 0, valMin = 10000;

            for (int i = 0; i < 5; i++)
            {
                if (punteggioMedio[i] > valMax)
                {
                    indirizzoMax = i;
                    valMax = punteggioMedio[i];
                }
                if (punteggioMedio[i] < valMin)
                {
                    indirizzoMin = i;
                    valMin = punteggioMedio[i];
                }
            }


            switch (indirizzoMin)
            {
                case 0:
                    Console.WriteLine("Il tablet peggiore ha effettuato un punteggio di " + Math.Round(punteggioMedio[0]) + "ed é:\nMarca: " + tablet1.getMarca() + "\nVelocitá: " + tablet1.getVelocita() + "\nDimensione: " + tablet1.getDimensione() + "\nDurata: " + tablet1.getDurata() + "\n\n");
                    break;
                case 1:
                    Console.WriteLine("Il tablet peggiore ha effettuato un punteggio di " + Math.Round(punteggioMedio[1]) + " ed é:\nMarca: " + tablet2.getMarca() + "\nVelocitá: " + tablet2.getVelocita() + "\nDimensione: " + tablet2.getDimensione() + "\nDurata: " + tablet2.getDurata() + "\n\n");
                    break;
                case 2:
                    Console.WriteLine("Il tablet peggiore ha effettuato un punteggio di " + Math.Round(punteggioMedio[2]) + " ed é:\nMarca: " + tablet3.getMarca() + "\nVelocitá: " + tablet3.getVelocita() + "\nDimensione: " + tablet3.getDimensione() + "\nDurata: " + tablet3.getDurata() + "\n\n");
                    break;
                case 3:
                    Console.WriteLine("Il tablet peggiore ha effettuato un punteggio di " + Math.Round(punteggioMedio[3]) + " ed é:\nMarca: " + tablet4.getMarca() + "\nVelocitá: " + tablet4.getVelocita() + "\nDimensione: " + tablet4.getDimensione() + "\nDurata: " + tablet4.getDurata() + "\n\n");
                    break;
                case 4:
                    Console.WriteLine("Il tablet peggiore ha effettuato un punteggio di " + Math.Round(punteggioMedio[4]) + " ed é:\nMarca: " + tablet5.getMarca() + "\nVelocitá: " + tablet5.getVelocita() + "\nDimensione: " + tablet5.getDimensione() + "\nDurata: " + tablet5.getDurata() + "\n\n");
                    break;
            }

            switch (indirizzoMax)
            {
                case 0:
                    Console.WriteLine("Il tablet migliore ha effettuato un punteggio di " + Math.Round(punteggioMedio[0]) + "ed é:\nMarca: " + tablet1.getMarca() + "\nVelocitá: " + tablet1.getVelocita() + "\nDimensione: " + tablet1.getDimensione() + "\nDurata: " + tablet1.getDurata() + "\n\n");
                    break;
                case 1:
                    Console.WriteLine("Il tablet migliore ha effettuato un punteggio di " + Math.Round(punteggioMedio[1]) + " ed é:\nMarca: " + tablet2.getMarca() + "\nVelocitá: " + tablet2.getVelocita() + "\nDimensione: " + tablet2.getDimensione() + "\nDurata: " + tablet2.getDurata() + "\n\n");
                    break;
                case 2:
                    Console.WriteLine("Il tablet migliore ha effettuato un punteggio di " + Math.Round(punteggioMedio[2]) + " ed é:\nMarca: " + tablet3.getMarca() + "\nVelocitá: " + tablet3.getVelocita() + "\nDimensione: " + tablet3.getDimensione() + "\nDurata: " + tablet3.getDurata() + "\n\n");
                    break;
                case 3:
                    Console.WriteLine("Il tablet migliore ha effettuato un punteggio di " + Math.Round(punteggioMedio[3]) +" ed é:\nMarca: " + tablet4.getMarca() + "\nVelocitá: " + tablet4.getVelocita() + "\nDimensione: " + tablet4.getDimensione() + "\nDurata: " + tablet4.getDurata() + "\n\n");
                    break;
                case 4:
                    Console.WriteLine("Il tablet migliore ha effettuato un punteggio di " + Math.Round(punteggioMedio[4]) + " ed é:\nMarca: " + tablet5.getMarca() + "\nVelocitá: " + tablet5.getVelocita() + "\nDimensione: " + tablet5.getDimensione() + "\nDurata: " + tablet5.getDurata() + "\n\n");
                    break;
            }
        }
    }
}