namespace TP2;

public class GestionJoueurs
{
    private Dictionary<string, Queue<Joueur>> joueursDansFileAttente = new Dictionary<string, Queue<Joueur>>();
    private List<Joueur> joueursDansPiste = new List<Joueur>(4);
    
    public void EntrerJoueurDansFileAttente(string pisteId, Joueur joueur)
    {
        if (!joueursDansFileAttente.ContainsKey(pisteId)) joueursDansFileAttente[pisteId] 
            = new Queue<Joueur>();
        
        joueursDansFileAttente[pisteId].Enqueue(joueur);
    }

    public void EntrerJoueurDansPiste(string pisteId)
    {
      /*  if (joueursDansPiste.Count >= 4)
        {
            Console.WriteLine("La piste est pleine.");
        }
        else
        {
            joueursDansPiste.Add(joueursDansFileAttente[pisteId]);
        }*/
    }

    public void EntrerJoueurDansMinigolf(Joueur joueur)
    {
    }
    
    public void SortirJoueurDuMinigolf(Joueur joueur)
    {
    }
}