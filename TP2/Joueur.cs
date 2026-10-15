namespace TP2;

public class Joueur
{
    private string Nom;
    private Stack<string> Historique; // On veut seulement la dernière action du joueur, on ne veut pas acceder les ancienne directement.
    public Joueur(string nom, Stack<string> historique)
    {
        Nom = nom;
        Historique = historique;
    }
    
    public string GetNom() => Nom;
    public Stack<string> GetHistorique() => Historique;
}