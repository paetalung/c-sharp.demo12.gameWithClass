using System;
using System.Collections.Generic;
using System.Text;

namespace demo12.gameWitthClass
{
    public class Player
    {
        public string Name { get; private set; }
        public int NowHeart { get; private set; }
        public string Action { get; set; }

        public Player(string name)
        {
            Name = name;
            NowHeart = 3;
        }
        public void DecreaseHeart()
        {
            NowHeart--;
        }
    }

    public class GameManager
    {
        public Player p1 { get; private set; }
        public Player p2 { get; private set; }

        public GameManager(string p1Name, string p2Name)
        {
            p1 = new Player(p1Name);
            p2 = new Player(p2Name);
        }

        public void SetPlayerAction(bool isPlayer1, string action)
        {
            if (isPlayer1)
            {
                p1.Action = action;
            }
            else
            {
                p2.Action = action;
            }
        }

        public void StartCalculation()
        {
            if(p1.Action =="H" && p2.Action == "H")
            {
                Console.WriteLine("No one is round win.");
            }
            else if(p1.Action == "S" && p2.Action == "H")
            {
                Console.WriteLine("P1 is round win.");
                p2.DecreaseHeart();
            }
            else if (p1.Action == "H" && p2.Action == "P")
            {
                Console.WriteLine("P2 is round win.");
                p1.DecreaseHeart();
            }
            else if (p1.Action == "S" && p2.Action == "H")
            {
                Console.WriteLine("P1 is round win.");
                p1.DecreaseHeart();
            }
            else if (p1.Action == "S" && p2.Action == "S")
            {
                Console.WriteLine("No one is round win.");
            }
            else if (p1.Action == "S" && p2.Action == "P")
            {
                Console.WriteLine("P1 is round win.");
                p2.DecreaseHeart();
            }
            else if (p1.Action == "P" && p2.Action == "H")
            {
                Console.WriteLine("P1 is round win.");
                p2.DecreaseHeart();
            }
            else if (p1.Action == "P" && p2.Action == "S")
            {
                Console.WriteLine("P2 is round win.");
                p1.DecreaseHeart();
            }
            else if (p1.Action == "P" && p2.Action == "P")
            {
                Console.WriteLine("No one is round win.");
            }

        }

        public bool GetIsGameEnded()
        {
            return !(p1.NowHeart <= 0 || p2.NowHeart <= 0);

        }

        public Player GetWinner()
        {
            if (p1.NowHeart <= 0) return p2;
            else return p1;
        }
    }
}
