using System;
using System.Collections.Generic;

class LibraryService
{
    private List<Livre> livres = new List<Livre>();
    private List<Abonne> abonnes = new List<Abonne>();
    private List<Emprunt> emprunts = new List<Emprunt>();

    public void AjouterLivre(Livre livre)
    {
        livres.Add(livre);
        Console.WriteLine("Livre ajouté !");
    }

    public void AjouterAbonne(Abonne abonne)
    {
        abonnes.Add(abonne);
        Console.WriteLine("Abonné ajouté !");
    }

    public void EmprunterLivre(Livre livre, Abonne abonne)
    {
        if (livre.EstDisponible())
        {
            Emprunt e = new Emprunt(emprunts.Count + 1, livre, abonne);
            emprunts.Add(e);
            livre.SetDisponibilite(false);

            Console.WriteLine("Emprunt effectué !");
        }
        else
        {
            Console.WriteLine("Livre non disponible !");
        }
    }
}
