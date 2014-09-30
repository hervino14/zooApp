using System;

namespace zooApp
{
    class Program
    {	
		// les cages dans le zoo
        public static Animal[] Zoo = new Animal[3];

        static void Main(string[] args)
        {
            Zoo[0] = new Chien("Milou");
            Zoo[1] = new Chat("miau");
            Zoo[2] = new Chat("Sisi");

            for (int j = 0; j < 3; j++)
            {
                Zoo[j].Presentation();
                Zoo[j].EmettreCris();
            }
            Console.ReadLine();
        }        
    }            
}
