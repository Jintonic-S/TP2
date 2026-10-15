namespace TP2;

public class Piste
{
    private string Id;
    private string Name;
    private char Difficulte;
    public Piste(string id, string nom, char difficulte)
    {
        Id = id;
        Name = nom;
        Difficulte = difficulte;
    }

    public string GetId() => Id;
    public string GetName() => Name;
    public char GetDifficulte() => Difficulte;
}
