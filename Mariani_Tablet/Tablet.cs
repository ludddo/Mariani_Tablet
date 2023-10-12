using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Mariani_Tablet
{
    internal class Tablet
    {
        private string marca;
        private double velocita;
        private int dimensione;
        private double durata;

        public Tablet() 
        {
            marca= string.Empty;
            velocita = 0;
            dimensione = 0;
            durata = 0;
        }

        public Tablet(string marca, double velocita, int dimensione, double durata)
        {
            this.marca = marca;
            this.velocita = velocita;
            this.dimensione = dimensione;
            this.durata = durata;
        }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public string getMarca() 
        {
            return this.marca;
        }

        public void setVelocita(double velocita) 
        {
            this.velocita = velocita;
        }

        public double getVelocita() 
        {
            return this.velocita;
        }

        public void setDimensione(int dimensione)
        {
            this.dimensione = dimensione;
        }

        public int getDimensione() 
        { 
            return dimensione; 
        }

        public void setDurata(double durata)
        {
            this.durata = durata;
        }

        public double getDurata()
        {
            return this.durata;
        }
    }
}
