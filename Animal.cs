using System;

namespace zooApp
{
    public class Animal:IAnimal
    {
        public String nom;
        public String cris;

        public Animal(String a, String b)
        {
            nom = a;
            cris = c;
        }
       
        public void EmettreCris()
        {
            Console.WriteLine("Mon cris c'est  " + cris + ".");
        }

        public void Presentation()
        {
            Console.WriteLine("Je m'appelle " + nom + ".");
        }
    }
}
