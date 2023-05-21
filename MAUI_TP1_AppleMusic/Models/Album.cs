using System;
using System.Collections.ObjectModel;

namespace MAUI_TP1_AppleMusic.Models
{
	public class Album
	{
        public string Nom { get; private set; }
        public string Auteur { get; private set; }
        public int Annee { get; private set; }
        public ReadOnlyCollection<Musique> Musiques { get; private set; }
        private readonly List<Musique> musiques = new List<Musique>();

        public string ImageName { get; private set; }

        public Album()
		{
		}

        public Album(string nom, string auteur, int annee, List<Musique> musiques, string imageName)
        {
            Nom = nom;
            Auteur = auteur;
            Annee = annee;
            Musiques = new ReadOnlyCollection<Musique>(musiques); ;
            ImageName = imageName;
        }
    }
}

