using System.Text;

namespace TP2;

public class Map
{
    private string[] toutFichier = File.ReadAllLines("map.txt");
    private int Hauteur { get; }
    private int Largeur { get; }
    private string[,] map; // Array pour pouvoir l'initialiser.
    StringBuilder builder = new();
    private string affichage;

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
                if(ligneSansEspace[j] != ' ') builder.Append(ligneSansEspace[j]);
            }
            builder.Append("\n");
        }
        builder.Append("\n");
        affichage = builder.ToString();
    }

    public void afficherMap()
    {
        Console.Write(affichage);
    }


}
