using System;
namespace MAUI_TP1_AppleMusic.Models
{
	public class Album
	{
        public string Nom { get; private set; }
        public string Auteur { get; private set; }
        public int Annee { get; private set; }
        public List<String> Musiques { get; private set; }

        public Album()
		{
		}

        public Album(string nom, string auteur, int annee, List<string> musiques)
        {
            Nom = nom;
            Auteur = auteur;
            Annee = annee;
            Musiques = musiques;
        }
    }
}

