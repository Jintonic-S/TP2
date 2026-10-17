namespace TP2;

public class Joueur
{
    private string Nom;
    private Stack<string> Historique = new();
    // On veut seulement la dernière action du joueur, on ne veut pas acceder les ancienne directement.
    public Joueur(string nom)
    {
        Nom = nom;
    }

    public string GetNom() => Nom;
    public Stack<string> GetHistorique() => Historique;
}
