// <copyright file="MiniGolf.cs" company="Cstjean">
// Jimmy Sauton, Xsyan Lavoie.
// </copyright>
namespace TP2;

/// <summary>
/// Classe du mini-golf.
/// </summary>
public class MiniGolf
{
    private List<Piste> pistes = new(); // Accès em O(1) et adaptable selon la quantité.

    private string txt = File.ReadAllText("pistes.txt");

    /// <summary>
    /// Constructeur.
    /// </summary>
    public MiniGolf()
    {
        CreePistes();
    }

    /// <summary>
    /// Méthode permettant de retourner une list de pistes.
    /// </summary>
    /// <returns>La liste de pistes.</returns>
    public List<Piste> CreePistes()
    {
        int compteur = 0;
        string id = "";
        string nom = "";

        char difficulte;
        for (int i = 0; i < txt.Length; i++)
        {
            if (compteur == 0)
            {
                if (txt[i] != ';')
                {
                    id += txt[i].ToString();
                }
                else
                {
                    compteur++;
                }
            }
            else if (compteur == 1)
            {
                if (txt[i] != ';')
                {
                    nom += txt[i].ToString();
                }
                else
                {
                    compteur++;
                }
            }
            else if (compteur == 2)
            {
                difficulte = txt[i];
                pistes.Add(new Piste(id, nom, difficulte));
                compteur = 0;
                id = "";
                nom = "";
            }
        }

        return pistes;
    }

    /// <summary>
    /// Retourne la liste de pistes.
    /// </summary>
    /// <returns>La liste de pistes.</returns>
    public List<Piste> GetPistes() => pistes;
}
