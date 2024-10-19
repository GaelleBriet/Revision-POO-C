// See https://aka.ms/new-console-template for more information
using Usine;

Console.WriteLine("Hello, World!");

LigneDeProduction ligneDeProduction = new LigneDeProduction();
PiloteDeLigne piloteDeLigne = new PiloteDeLigne(ligneDeProduction, 1, "Paul");
Responsable responsable = new Responsable(piloteDeLigne, 2, "Rémy");
Directeur directeur = new Directeur(responsable, 3, "David");

Console.WriteLine(piloteDeLigne);
Console.WriteLine(responsable);
Console.WriteLine(directeur);

Usine.Usine usine = new Usine.Usine(directeur);
Simulateur simulateur = new Simulateur(usine);
simulateur.Demarrer();