using System;
namespace MAUI_TP1_AppleMusic.Models
{
	public class Catgerorie
	{
        public string Nom { get; private set; }
        public string ImageName { get; private set; }

        public Catgerorie()
		{
		}

        public Catgerorie(string nom, string imageName)
        {
            Nom = nom;
            ImageName = imageName;
        }
    }
}

