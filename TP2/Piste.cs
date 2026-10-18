// <copyright file="Piste.cs" company="Cstjean">
// Jimmy Sauton, Xsyan Lavoie.
// </copyright>

namespace TP2;

/// <summary>
/// Classe pour les pistes.
/// </summary>
public class Piste
{
    private string id;
    private string name;
    private char difficulte;

    /// <summary>
    /// Constructeur.
    /// </summary>
    /// <param name="id">Id de la piste.</param>
    /// <param name="nom">Nom de la piste.</param>
    /// <param name="difficulte">Difficulte de la piste.</param>
    public Piste(string id, string nom, char difficulte)
    {
        this.id = id;
        name = nom;
        this.difficulte = difficulte;
    }

    /// <summary>
    /// Retourne l'id de la piste.
    /// </summary>
    /// <returns>L'id de la piste.</returns>
    public string GetId() => id;

    /// <summary>
    /// Retourne le nom de la piste.
    /// </summary>
    /// <returns>Le nom de la piste.</returns>
    public string GetName() => name;

    /// <summary>
    /// Retourne la difficultée de la piste.
    /// </summary>
    /// <returns>La difficultée de la piste.</returns>
    public char GetDifficulte() => difficulte;
}
