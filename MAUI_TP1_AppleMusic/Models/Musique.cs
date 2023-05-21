using System;
namespace MAUI_TP1_AppleMusic.Models
{
	public class Musique
	{
        public int Numero { get; private set; }
        public string Nom { get; private set; }
        public bool Fav { get; private set; }
 
        public Musique()
		{
		}

        public Musique(int numero, string nom, bool fav)
        {
            Numero = numero;
            Nom = nom;
            Fav = fav;
        }
    }
}

