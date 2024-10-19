using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Usine
{
    public class Responsable : Employe
    {
        private PiloteDeLigne _piloteDeLigne;

        public Responsable(PiloteDeLigne piloteDeLigne, int matricule, string prenom)
            : base(matricule, prenom)
        {
            this.PiloteDeLigne = piloteDeLigne;
        }

        public PiloteDeLigne PiloteDeLigne { 
            get => _piloteDeLigne; 
            set => _piloteDeLigne = value; 
        }

        public override void Produire()
        {
            while (true)
            {
                try
                {
                    PiloteDeLigne.Produire();
                }
                catch (Incident2 i)
                {
                    Console.WriteLine(this.Prenom + $" à traité l'incident niveau {i.Niveau}");
                }
            }
        }

        public override string ToString()
        {
            return $"Responsable: {base.EmployeToString()}";
        }
    }
}