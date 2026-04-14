using System;

class Emprunt
{
    private int id;
    private DateTime dateEmprunt;
    private Livre livre;
    private Abonne abonne;

    public Emprunt(int id, Livre livre, Abonne abonne)
    {
        this.id = id;
        this.livre = livre;
        this.abonne = abonne;
        this.dateEmprunt = DateTime.Now;
    }
}