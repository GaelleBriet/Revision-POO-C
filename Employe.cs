using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Usine
{
    public abstract class Employe
    {
        private int _matricule;
        private string _prenom;

        public Employe(int matricule, string prenom)
        {
            this._matricule = matricule;
            this._prenom = prenom;
        }

        public int Matricule
        {
            get => _matricule;
            set => _matricule = value;
        }

        public string Prenom
        {
            get => _prenom;
            set => _prenom = value;
        }

        public abstract void Produire();

        public string EmployeToString()
        {
            return "Matricule: " + Matricule + ", Prenom: " + Prenom;
        }
    }
}