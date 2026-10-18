namespace TP2;

/// <summary>
/// Classe permettant de faire la gestion des joueurs.
/// </summary>
public class GestionJoueurs
{
    // On veut associer une file d'attente de joueur à une piste.
    private Dictionary<string, Queue<Joueur>> joueursDansFileAttente = new();

    // On veut associer une liste de joueur à une piste.
    private Dictionary<string, List<Joueur>> joueursDansPiste = new();

    // On ne veut pas 2 fois les mêmes personnes dans le minigolf
    private HashSet<Joueur> joueurDansMinigolf = new();

    /// <summary>
    /// Méthode pour entrer un joueur dans la file d'attente d'une piste.
    /// </summary>
    /// <param name="pisteId">Id de la piste.</param>
    /// <param name="joueur">Joueur.</param>
    public void EntrerJoueurDansFileAttente(string pisteId, Joueur joueur)
    {
        if (!joueursDansFileAttente.ContainsKey(pisteId))
        {
            joueursDansFileAttente[pisteId] = new Queue<Joueur>();
        }

        joueursDansFileAttente[pisteId].Enqueue(joueur);
        joueur.GetHistorique().Push($"Entrer dans la file d'attente de la {pisteId}.");
    }

    /// <summary>
    /// Méthode pour entrer un joueur dans une piste choisie.
    /// </summary>
    /// <param name="pisteId">Id de la piste.</param>
    public void EntrerJoueurDansPiste(string pisteId)
    {
        if (!joueursDansPiste.ContainsKey(pisteId)) joueursDansPiste[pisteId] = new List<Joueur>(4);
        if (joueursDansPiste[pisteId].Count < 4)
        {
            Joueur joueur = joueursDansFileAttente[pisteId].Peek();
            joueursDansPiste[pisteId].Add(joueursDansFileAttente[pisteId].Dequeue());
            joueur.GetHistorique().Push($"Entrer dans la piste {pisteId}");
        }
    }

    /// <summary>
    /// Méthode pour entrer un joueur dans le mini-golf.
    /// </summary>
    /// <param name="joueur">Joueur.</param>
    public void EntrerJoueurDansMiniGolf(Joueur joueur)
    {
        joueurDansMinigolf.Add(joueur);
        joueur.GetHistorique().Push("Entrer dans le mini-golf");
    }

    /// <summary>
    /// Méthode pour sortir un joueur du mini-golf.
    /// </summary>
    /// <param name="joueur">Joueur.</param>
    public void SortirJoueurDuMiniGolf(Joueur joueur)
    {
        joueurDansMinigolf.Remove(joueur);
        joueur.GetHistorique().Push("Sortir du mini-golf.");
    }

    /// <summary>
    /// Pour récupérer le nombre de joueurs dans le mini-golf.
    /// </summary>
    /// <returns>Le nombre de joueurs.</returns>
    public int GetJoueursDansMinigolf()
    {
        return joueurDansMinigolf.Count;
    }
}
