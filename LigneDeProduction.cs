using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Usine
{
    public class LigneDeProduction : Machine
    {
        private Random _random = new Random();

        public LigneDeProduction()
            : base(++DernierNumeroInventaire)
        {
            //throw new System.NotImplementedException();
        }

        public override void Produire()
        {
            while (true)
            {
                int incidentValue = _random.Next(0, 100);
                Thread.Sleep(1000);

                    if (incidentValue > 97)
                    {
                        throw new Incident4();
                    }
                    else if (incidentValue > 85)
                    {
                        throw new Incident3();
                    }
                    else if(incidentValue > 75)
                    {
                        throw new Incident2();
                    }
                    else if(incidentValue > 40)
                    {
                        throw new Incident1();
                    }
                     else 
                    {
                        Console.Write(".");
                    }
            }
        }

        public override string ToString()
        {
            return $"Ligne de production n°{NumeroInventaire}";
        }
    }
}