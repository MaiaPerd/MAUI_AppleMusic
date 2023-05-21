using System;
using MAUI_TP1_AppleMusic.Models;

namespace MAUI_TP1_AppleMusic.Stub
{
	public class AlbumStub
	{
		public AlbumStub()
		{
		}

        public static Album getAlbum()
        {
            return new Album(nom: "Speak No Evil (Ruby Van Gelder Edition)", auteur: "Wayne shorter", annee: 1966, musiques: getMusiqueList(), imageName: "speak_no_evil.png");
        }

        public static List<Album> getAlbumList()
		{
			List<Album> list = new();

			list.Add(new Album(nom: "Speak No Evil (Ruby Van Gelder Edition)", auteur: "Wayne shorter", annee: 1966, musiques: getMusiqueList(), imageName: "speak_no_evil.png"));
            list.Add(new Album(nom: "Know What I Mean? (Remastered)", auteur: "Cannonball Adderley & Bill Evans", annee: 1961, musiques: getMusiqueList(), imageName: "know_what_i_mean.png"));
            list.Add(new Album(nom: "on the tender spot of every calloused moment", auteur: "Ambrose Akinmusire", annee: 2020, musiques: getMusiqueList(), imageName: "on_the_tender_spot.png"));
            list.Add(new Album(nom: "Bitches Brew", auteur: "Miles Davis", annee: 1970, musiques: getMusiqueList(), imageName: "bitches_brew.png"));
            list.Add(new Album(nom: "Search for the New Land (The Ruby Van Gelder Edition Remastered)", auteur: "Lee Morgan", annee: 1964, musiques: getMusiqueList(), imageName: "search_for_the_new_land.png"));
            list.Add(new Album(nom: "Chroniques bluesymentales", auteur: "Hubert-Félix Thiéfaine", annee: 1990, musiques: getMusiqueList(), imageName: "chroniques_bluesymentales.png"));

            return list;
        }

        public static List<Musique> getMusiqueList()
        {
            List<Musique> list = new();

            list.Add(new Musique(numero: 1, nom: "Witch Hunt", fav: true));
            list.Add(new Musique(numero: 2, nom: "Witch Hunt", fav: false));
            list.Add(new Musique(numero: 3, nom: "Witch Hunt", fav: false));
            list.Add(new Musique(numero: 4, nom: "Witch Hunt", fav: false));
            list.Add(new Musique(numero: 5, nom: "Witch Hunt", fav: false));
            list.Add(new Musique(numero: 6, nom: "Witch Hunt", fav: true));
            list.Add(new Musique(numero: 7, nom: "Witch Hunt", fav: false));
            list.Add(new Musique(numero: 8, nom: "Witch Hunt", fav: false));
            list.Add(new Musique(numero: 9, nom: "Witch Hunt", fav: true));
            list.Add(new Musique(numero: 10, nom: "Witch Hunt", fav: false));
            list.Add(new Musique(numero: 11, nom: "Witch Hunt (Ruby Van Gelder Edition)", fav: true));

            return list;
        }

        public static List<Catgerorie> getCategList()
        {
            List<Catgerorie> list = new();

            list.Add(new Catgerorie(nom: "Playlists", imageName: "playlists.png"));
            list.Add(new Catgerorie(nom: "Artistes", imageName: "artistes.png"));
            list.Add(new Catgerorie(nom: "Albums", imageName: "albums.png"));
            list.Add(new Catgerorie(nom: "Compilations", imageName: "compilations.png"));

            return list;
        }

      
    }
}

