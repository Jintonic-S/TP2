namespace TP2;

/// <summary>
/// Classe d'un joueur.
/// </summary>
public class Joueur
{
    private string nom;

    // On veut seulement la dernière action du joueur, on ne veut pas acceder les ancienne directement.
    private Stack<string> historique = new();

    /// <summary>
    /// Constructeur, initialise une instance de la classe joueur.
    /// </summary>
    /// <param name="nom">Nom du joueur.</param>
    public Joueur(string nom)
    {
        this.nom = nom;
    }

    /// <summary>
    /// Retourne le nom du joueur.
    /// </summary>
    /// <returns>Le nom du joueur.</returns>
    public string GetNom() => nom;

    /// <summary>
    /// Retourne l'historique du joueur.
    /// </summary>
    /// <returns>L'historique du joueur.</returns>
    public Stack<string> GetHistorique() => historique;
}
