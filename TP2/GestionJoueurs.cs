namespace TP2;

public class GestionJoueurs
{
    private Dictionary<string, Joueur> joueursDansFileAttente = new Dictionary<string, Joueur>();
    private List<Joueur> joueursDansPiste = new List<Joueur>(4);
    
    public void EntrerJoueurDansFileAttente(string pisteId, Joueur joueur)
    {
        joueursDansFileAttente.Add(pisteId, joueur);
    }

    public void EntrerJoueurDansPiste(string pisteId)
    {
    }

    public void EntrerJoueurDansMinigolf(Joueur joueur)
    {
    }
    
    public void SortirJoueurDuMinigolf(Joueur joueur)
    {
    }
}