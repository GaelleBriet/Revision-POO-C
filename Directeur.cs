using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Usine
{
    public class Directeur : Employe
    {
        private Responsable _responsable;

        public Directeur(Responsable responsable, int matricule, string prenom)
            : base(matricule, prenom)
        {
            this._responsable = responsable;
        }

        public Responsable Responsable { 
            get => _responsable; 
            set => _responsable = value; 
        }

        public override void Produire()
        {
            while(true)
            {
                try
                {
                    Responsable.Produire();
                }
                catch (Incident3 i)
                {
                    Console.WriteLine( this.Prenom + $" à traité l'incident niveau {i.Niveau}" );
                }
            }
        }
        public override string ToString()
        {
            return $"Directeur: {base.EmployeToString()}";
        }

    }
}