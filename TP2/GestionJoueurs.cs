namespace TP2;

public class GestionJoueurs
{
    private Dictionary<string, Queue<Joueur>> joueursDansFileAttente = new Dictionary<string, Queue<Joueur>>(); 
    // On veut associer une file d'attente de joueur à une piste.
    private Dictionary<string, List<Joueur>> joueursDansPiste = new Dictionary<string, List<Joueur>>();
    //On veut associer une liste de joueur à une piste.
    private HashSet<Joueur> joueurDansMinigolf = new HashSet<Joueur>();
    // On ne veut pas 2 fois les mêmes personnes dans le minigolf
    
    public void EntrerJoueurDansFileAttente(string pisteId, Joueur joueur)
    {
        if (!joueursDansFileAttente.ContainsKey(pisteId)) joueursDansFileAttente[pisteId] 
            = new Queue<Joueur>();
        
        joueursDansFileAttente[pisteId].Enqueue(joueur);
        joueur.GetHistorique().Push($"Joueur {joueur.GetNom()} est entré dans la file d'attente" +
                                    $" de la piste {pisteId}");
    }

    public void EntrerJoueurDansPiste(string pisteId)
    {
        if (!joueursDansPiste.ContainsKey(pisteId)) joueursDansPiste[pisteId] 
            = new List<Joueur>(4);
        if (joueursDansPiste[pisteId].Count < 4)
        {
            Joueur joueur = joueursDansFileAttente[pisteId].Peek();
            joueursDansPiste[pisteId].Add(joueursDansFileAttente[pisteId].Dequeue());
            joueur.GetHistorique().Push($"Joueur {joueur.GetNom()} est entré dans la piste {pisteId}");
        }
    }

    public void EntrerJoueurDansMinigolf(Joueur joueur)
    {
        joueurDansMinigolf.Add(joueur);
        joueur.GetHistorique().Push($"Joueur {joueur.GetNom()} est entré dans le minigolf");
    }
    
    public void SortirJoueurDuMinigolf(Joueur joueur)
    {
        joueurDansMinigolf.Remove(joueur);
        joueur.GetHistorique().Push($"Joueur {joueur.GetNom()} est sorti du minigolf");
    }
}