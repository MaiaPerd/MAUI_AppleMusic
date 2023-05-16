using System;
using MAUI_TP1_AppleMusic.Models;

namespace MAUI_TP1_AppleMusic.Stub
{
	public class AlbumStub
	{
		public AlbumStub()
		{
		}

		public static List<Album> getAlbumList()
		{
			List<Album> list = new();

			list.Add(new Album(nom: "Speak No Evil (Ruby Van Gelder Edition)", auteur: "Wayne shorter", annee: 1966, musiques: getMusiqueList()));
            list.Add(new Album(nom: "Speak No Evil (Ruby Van Gelder Edition)", auteur: "Wayne shorter", annee: 1966, musiques: getMusiqueList()));
            list.Add(new Album(nom: "Speak No Evil (Ruby Van Gelder Edition)", auteur: "Wayne shorter", annee: 1966, musiques: getMusiqueList()));
            list.Add(new Album(nom: "Speak No Evil (Ruby Van Gelder Edition)", auteur: "Wayne shorter", annee: 1966, musiques: getMusiqueList()));
            list.Add(new Album(nom: "Speak No Evil (Ruby Van Gelder Edition)", auteur: "Wayne shorter", annee: 1966, musiques: getMusiqueList()));
            list.Add(new Album(nom: "Speak No Evil (Ruby Van Gelder Edition)", auteur: "Wayne shorter", annee: 1966, musiques: getMusiqueList()));

            return list;
        }

        public static List<String> getMusiqueList()
        {
            List<String> list = new();

            list.Add("Witch Hunt");
            list.Add("Witch Hunt");
            list.Add("Witch Hunt");
            list.Add("Witch Hunt");
            list.Add("Witch Hunt");
            list.Add("Witch Hunt");
            list.Add("Witch Hunt");
            list.Add("Witch Hunt");

            return list;
        }
    }
}

