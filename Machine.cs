using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Usine
{
    public abstract class Machine
    {
        private static int dernierNumeroInventaire = 0;
        private int _numeroInventaire;

        protected Machine(int numeroInventaire)
        {
            this._numeroInventaire = ++dernierNumeroInventaire;
        }

        protected static int DernierNumeroInventaire { 
            get => dernierNumeroInventaire; 
            set => dernierNumeroInventaire = value; 
        }

        public int NumeroInventaire {
            get => _numeroInventaire; 
            protected set => _numeroInventaire = value; 
        }

        public abstract void Produire();
    }
}