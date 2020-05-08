using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVolsWinForm
{
    [Serializable]
    class Avion
    {
        private int numero;
        private string marque;
        private string type;
        private int capacite;
        public Avion() { }
        public Avion(int numero, string marque, string type, int capacite)
        {
            this.numero = numero;
            this.marque = marque;
            this.type = type;
            this.capacite = capacite;
        }

        public int Numero { get { return numero; } set { numero = value; } }
        public string Marque { get { return marque; } set { marque = value; } }
        public string Type { get { return type; } set { type = value; } }
        public int Capacite { get { return capacite; } set { capacite = value; } }

        public override string ToString()
        {
            return this.numero +" " + this.marque + " " + this.type;
        }

    }
}
