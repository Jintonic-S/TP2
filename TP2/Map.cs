// <copyright file="Map.cs" company="Cstjean">
// Jimmy Sauton, Xsyan Lavoie.
// </copyright>

using System.Text;

namespace TP2;

/// <summary>
/// Classe de la map.
/// </summary>
public class Map
{
    private string[] toutFichier = File.ReadAllLines("map.txt");

    private string[,] map; // Array pour pouvoir l'initialiser.
    private StringBuilder builder = new();
    private string affichage;

    /// <summary>
    /// Constructeur.
    /// </summary>
    public Map()
    {
        string[] dimension = toutFichier[0].Split(';');

        Hauteur = int.Parse(dimension[0]);
        Largeur = int.Parse(dimension[1]);

        map = new string[Hauteur, Largeur];

        for (int i = 0; i < Hauteur; i++)
        {
            string ligneSansEspace = toutFichier[i + 1];
            for (int j = 0; j < ligneSansEspace.Length; j++)
            {
                if (ligneSansEspace[j] != ' ')
                {
                    builder.Append(ligneSansEspace[j]);
                }
            }

            builder.Append("\n");
        }

        builder.Append("\n");
        affichage = builder.ToString();
    }

    private int Hauteur { get; }

    private int Largeur { get; }

    /// <summary>
    /// Affiche la map.
    /// </summary>
    public void AfficherMap()
    {
        Console.Write(affichage);
    }
}
