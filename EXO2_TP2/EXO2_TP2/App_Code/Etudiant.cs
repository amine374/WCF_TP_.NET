using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for Etudiant
/// </summary>
[DataContract]
public class Etudiant
{
    private string nom;
    String prenom;
    int age;


    public Etudiant(String nom, String prenom, int age)
    {
        //
        // TODO: Add constructor logic here
        //
        this.Nom = nom;
        this.Prenom = prenom;
        this.Age = age;
    }
    [DataMember]
    public string Nom
    {
        get
        {
            return nom;
        }

        set
        {
            nom = value;
        }
    }

    [DataMember]
    public string Prenom
    {
        get
        {
            return prenom;
        }

        set
        {
            prenom = value;
        }
    }

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            age = value;
        }
    }
}