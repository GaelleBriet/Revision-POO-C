using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Usine
{
    public class Simulateur
    {
        private Usine _usine;

        public Simulateur(Usine usine)
        {
            this._usine = usine;
        }

        public Usine Usine {
            get => _usine;
            set => _usine = value;
        }

        public void Demarrer()
        {
            try
            {
                this.Usine.Demarrer();
            }
            catch (Incident4)
            {
                Console.WriteLine("BOUM !");
            }
        }
    }
}