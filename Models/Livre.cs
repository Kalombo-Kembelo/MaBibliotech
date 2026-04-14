class Livre
{
    private int id;
    private string titre;
    private string auteur;
    private bool disponible;

    public Livre(int id, string titre, string auteur)
    {
        this.id = id;
        this.titre = titre;
        this.auteur = auteur;
        this.disponible = true;
    }

    public bool EstDisponible()
    {
        return disponible;
    }

    public void SetDisponibilite(bool dispo)
    {
        disponible = dispo;
    }
}
