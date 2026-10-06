namespace TP2;

public class Joueur
{
    private string Nom;
    private Stack<string> Historique;
    public Joueur(string nom, Stack<string> historique)
    {
        Nom = nom;
        Historique = historique;
    }
}