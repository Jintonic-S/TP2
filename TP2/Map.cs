namespace TP2;

public class Map
{
    private string[] toutFichier = File.ReadAllLines("map.txt");
    private int Hauteur { get; }
    private int Largeur { get; }
    private string[,] map; // Array pour pouvoir l'initialiser.
    public Map()
    {
        string[] dimension = toutFichier[0].Split(';');
        
        Hauteur = int.Parse(dimension[0]);
        Largeur = int.Parse(dimension[1]); 
        
        map = new string[Hauteur, Largeur];
        
        
        for (int i = 0; i < Hauteur; i++)
        {
            string[] ligneSansEspace = toutFichier[i + 1].Split(' ');
            
            for (int j = 0; j < Largeur; j++)
            {
                map[i, j] = ligneSansEspace[j];
            }
        }
    }

    public void afficherMap()
    {
        int compteur = 0;
        foreach (var item in map)
        {
            if (compteur == Largeur)
            {
                compteur = 0;
                Console.WriteLine();
            }
            Console.Write(item);
            compteur++;
        }
    }
    

}