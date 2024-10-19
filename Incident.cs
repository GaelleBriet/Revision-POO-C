using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Usine
{
    public abstract class Incident : Exception
    {
        private int _niveau;

        public Incident(int niveau)
        {
            this._niveau = niveau;
        }

        public int Niveau {
            get => _niveau; 
            set => _niveau = value; 
        }
    }
}