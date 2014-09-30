using System;

namespace ZooApp
{
    class Program
    {
        static void Main(string[] args)
        {
			Animal animal = new Animal("Milou","aboie", "chien");
			
			animal.Presentation();
			animal.EmettreCris();
			
            Console.ReadLine();
        }             
    }
