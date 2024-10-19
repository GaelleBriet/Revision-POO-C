using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Usine
{
    public class Usine
    {
        private Directeur _directeur;

        public Usine(Directeur directeur)
        {
            this._directeur = directeur ?? throw new ArgumentNullException(nameof(directeur));
        }

        public Directeur Directeur { 
            get => _directeur; 
            set => _directeur = value ?? throw new ArgumentNullException(nameof(value)); 
        }

        public void Demarrer()
        {
           this._directeur.Produire();
        }
    }
}