using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Etudiant
/// </summary>
public class Etudiant
{
    public String nom;
    public String prenom;
    public int age;
    public Etudiant(String nom, String prenom, int age)
    {
        //
        // TODO: Add constructor logic here
        //
        this.nom = nom;
        this.prenom = prenom;
        this.age = age;
    }
}