using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Usine
{
    public class PiloteDeLigne : Employe
    {
        private LigneDeProduction _ligneDeProduction;

        public PiloteDeLigne(LigneDeProduction ligneDeProduction, int matricule, string prenom)
            : base(matricule, prenom)
        {
            this._ligneDeProduction = ligneDeProduction;
        }

        public LigneDeProduction LigneDeProduction { 
            get => _ligneDeProduction; 
            set => _ligneDeProduction = value; 
        }

        public override void Produire()
        {
            while(true)
            {
                try
                {
                    _ligneDeProduction.Produire();
                }
                catch (Incident1 i)
                {
                    Console.WriteLine(this.Prenom + $" à traité l'incident niveau {i.Niveau}");
                }
            }
        }

        public override string ToString()
        {
            return $"Pilote de ligne: {base.EmployeToString()}";
        }
    }
}