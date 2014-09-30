using System;

namespace zooApp
{
    public class Animal:IAnimal
    {
        public String nom;
        public String cris;
		public String race;

        public Animal(String le_nom, String le_cris, String la_race)
        {
            nom = le_nom;
            cris = le_cris;
			race =la_race;
        }
       
        public void EmettreCris()
        {
            Console.WriteLine("Mon cris c'est  " + cris + ".");
        }

        public void Presentation()
        {
			Console.WriteLine("Bonjour! Je suis un(e) " + race + ".");
            Console.WriteLine("Je m'appelle " + nom + ".");
            Console.WriteLine("Mon cris c'est  " + jeDis + ".");
        }
    }
}
