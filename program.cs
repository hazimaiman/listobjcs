using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            Player player1 = new Player("Aiman");
            Player player2 = new Player("Hazim");
            Player player3 = new Player("Cindy");

            players.Add(player1) ;
            players.Add(player2);
            players.Add(player3);


            foreach( Player player in players)
            {
                Console.WriteLine(player.username);
            }

            Console.ReadKey();
        }

    }
    class Player 
    {
        public String username;

        public Player(String username)
        {
            this.username = username;
        }

        public override string ToString()
        {
            return username;
        }



    }




}




