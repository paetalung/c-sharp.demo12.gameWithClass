using System;

namespace demo12.gameWitthClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var gameManager = new GameManager("John", "Doe");
            do
            {
                Console.WriteLine("Please select action for player1 :");
                var player1Input = Console.ReadLine();
                gameManager.SetPlayerAction(true, player1Input);

                Console.WriteLine("Please select action for player2 :");
                var player2Input = Console.ReadLine();
                gameManager.SetPlayerAction(false, player2Input);

                gameManager.StartCalculation();
            } while (gameManager.GetIsGameEnded());

            var winner = gameManager.GetWinner();
            Console.WriteLine("The winner is :" + winner.Name);
        }
    }
}
