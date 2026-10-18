// <copyright file="AffichageConsole.cs" company="Cstjean">
// Jimmy Sauton, Xsyan Lavoie.
// </copyright>
using System.Text;

namespace TP2;

/// <summary>
/// Classe permettant les affichages dans la console.
/// </summary>
public class AffichageConsole
{
    /// <summary>
    /// Méthode qui affiche la map, le nombre de joueurs présents et les pistes.
    /// </summary>
    /// <param name="minigolf">Minigolf ou se trouve les pistes.</param>
    /// <param name="map">Map des pistes.</param>
    /// <param name="gestionJoueurs">Informations des joueurs.</param>
    public static void Afficher(MiniGolf minigolf, Map map, GestionJoueurs gestionJoueurs)
    {
        map.AfficherMap();
        Console.WriteLine($"{gestionJoueurs.GetJoueursDansMinigolf()} " +
                          $"joueur(s) présent(s) dans le mini-golf.\n");
        foreach (var piste in minigolf.GetPistes())
        {
            Console.WriteLine($"O   {piste.GetId()}         {piste.GetName()} ({piste.GetDifficulte()})\n");
        }
    }

    /// <summary>
    /// Méthode qui affiche l'historique d'un joueur.
    /// </summary>
    /// <param name="joueur">Joueur.</param>
    public static void AfficherHistoriqueJoueur(Joueur joueur)
    {
        StringBuilder builder = new();
        builder.Append($"\n### {joueur.GetNom()} ### \n");
        foreach (var action in joueur.GetHistorique())
        {
            builder.Append($"- {action}\n");
        }

        Console.WriteLine(builder.ToString());
    }
}
