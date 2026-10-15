using System.Runtime.Serialization;

namespace TP2;

public class MiniGolf
{
    List<Piste> pistes = new(); // Accès em O(1) et adaptable selon la quantité.

    string txt = File.ReadAllText("pistes.txt");

    public MiniGolf()
    {
        CreePistes();
    }

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
                    compteur++;
            }else if (compteur == 1)
            {
                if (txt[i] != ';')
                {
                    nom += txt[i].ToString();
                }
                else
                    compteur++;

            }else if (compteur == 2)
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


    public List<Piste> GetPistes() => pistes;
}
