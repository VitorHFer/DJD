using System;

namespace Vegito
{
    class Program
    {
        static void Main(string[] args)
        {
            string Goku, Vegeta, name;
            int attackV, attackG, defenseV, defenseG, intellectV, intellectG, ATT, DEF, INT;

            Vegeta = "Vegeta Stats";
            attackV = 6000;
            defenseV = 5870;
            intellectV = 5712;
            Console.WriteLine("Vegeta Stats:\n ATT:{0}\n DEF:{1}\n INT:{2}", attackV, defenseV, intellectV); 

            Goku = "Goku Stats";
            attackG = 4960;
            defenseG = 3213;
            intellectG = 6646;
            Console.WriteLine("Goku Stats:\n ATT:{0}\n DEF:{1}\n INT:{2}", attackG, defenseG, intellectG);

            Console.WriteLine("FUSIIIIIION!\n Vegito was created!");

            name = "Vegito";
            ATT = ((attackV + attackG) / 2);
            DEF = ((defenseV + defenseG) / 2);
            INT = ((intellectV + intellectG) / 2);

            Console.WriteLine("Vegito Stats:\n ATT:{0}\n DEF:{1}\n INT:{2}", ATT, DEF, INT);
            Console.ReadLine();

        }
    }
}
