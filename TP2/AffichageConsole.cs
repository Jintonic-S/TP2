using System.Text;

namespace TP2;

public class AffichageConsole
{
    public static void Afficher(MiniGolf minigolf, Map map, GestionJoueurs gestionJoueurs)
    {
        map.afficherMap();
        Console.WriteLine($"{gestionJoueurs.GetJoueursDansMinigolf()} " +
                          $"joueur(s) présent(s) dans le mini-golf.\n");

    }

    public static void AfficherHistoriqueJoueur(Joueur joueur)
    {
        StringBuilder builder = new();
        builder.Append($"\n### {joueur.GetNom()} ###\n");
        foreach (var action in joueur.GetHistorique())
        {
            builder.Append($"- {action}\n");
        }
        Console.WriteLine(builder.ToString());
    }
}
