using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikac1
{
	class Program
	{
		static void Main(string[] args)
		{
			string testString = "ovo je stestni atring 12312312312 3333";
			int broj1 = 1;
			int broj2 = 2;

			// instanciranje novog objekta tipa Card  
			Card MojaPrvaKarta = new Card();
			MojaPrvaKarta.Name = "Gojf";
			MojaPrvaKarta.Type = 1;

			Card MojaDrugaKarta = new Card();
			MojaDrugaKarta.Name = "Sol Ring";
			MojaDrugaKarta.Type = 3;

			List<Card> ListaKarata = new List<Card>();
			ListaKarata.Add(MojaPrvaKarta);
			ListaKarata.Add(MojaDrugaKarta);

			for (int i = 0; i < 2; i++)
			{
				int tip = ListaKarata.ElementAt(i).Type;
				string ime = ListaKarata.ElementAt(i).Name;
				Console.WriteLine(tip + ime);
			}
			int rezultat = nasaMetoda(broj1, broj2);

			//return type
			//ime metode
			// sto metoda prima u sebe
			// {} tijelo metode - ono sto metoda radi
			int nasaMetoda(int x, int y)
			{
				int retVal = x + y;

				return retVal;
			}
			Console.WriteLine( MojaPrvaKarta.Name + "    : " + MojaPrvaKarta.Type);
			Console.WriteLine(MojaDrugaKarta.Name + "    : " + MojaDrugaKarta.Type);
			Console.ReadKey();
		}
	}

	class Card
	{
		public string Name { get; set; }

		// Type 1 - Creature
		// Type 2 - Instant
		// Type 3 - Artifact
		public int Type { get; set; }
	}
}
