using System;
using System.Collections.Generic;

namespace EqualPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Player ana1 = new Player(PlayerClass.Tank, "Ana" );
            Player paulo = new Player(PlayerClass.Slayer, "Paulo" );
            Player ana2 = new Player(PlayerClass.Tank, "Ana" );


            HashSet<Player> setOfPlayers = new HashSet<Player>();
            setOfPlayers.Add(ana1);
            setOfPlayers.Add(paulo);
            setOfPlayers.Add(ana2);

            foreach (Player p in setOfPlayers)
            {
                Console.WriteLine($"{p.Name} is a {p.PClass}");
            }
        }
    }
}
