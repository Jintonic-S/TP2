using System.Text;

namespace TP2;

public class AffichageConsole
{
    public static void Afficher(MiniGolf minigolf, Map map, GestionJoueurs gestionJoueurs)
    {
    }

    public static void AfficherHistoriqueJoueur(Joueur joueur)
    {
        StringBuilder builder = new();
        builder.Append($"### {joueur} ###\n");
        foreach (var action in joueur.GetHistorique())
        {
            builder.Append($"- {action}\n");
        }
        Console.WriteLine(builder.ToString());
    }
}
