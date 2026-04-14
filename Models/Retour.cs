using System;

class Retour
{
    private int id;
    private DateTime dateRetour;
    private Emprunt emprunt;

    public Retour(int id, Emprunt emprunt)
    {
        this.id = id;
        this.emprunt = emprunt;
        this.dateRetour = DateTime.Now;
    }
}