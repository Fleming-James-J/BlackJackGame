//James Fleming
//CS-021 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_Skills_Demo_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int optionCntr = 0;
           
            //bools for checking dealer and player sticking or going bust.
            bool playerStick = false;
            bool dealerStick = false;
            bool playerBust = false;
            bool dealerBust = false;


            //Welcome Screen
            header();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ╔═══════════════════════════════════════╗");
            Console.WriteLine(" ║ Press any key to play                 ║");
            Console.WriteLine(" ╚═══════════════════════════════════════╝");

            //reads if any key is pressed
            Console.ReadKey();

            //creates random generator
            Random rand = new Random();

            //create instance of Player Object
            Player Player1 = new Player();

            //create an instance of Dealer Object
            Dealer dealer1 = new Dealer();

            //adds a score between 1-11 to the players score
            Player1.setRunningTotal(Player1.getRunningTotal() + rand.Next(1, 11));

            //method for displaying information to the user
            playerView(Player1.getRunningTotal());

            //read users input for hit or stick
            optionCntr = Convert.ToInt32(Console.ReadLine());

            //Player hitting or sticking
            while (optionCntr == 1)
            {   
                //adds new card to score
                Player1.setRunningTotal(Player1.getRunningTotal() + rand.Next(1, 11));
                
                //checks if player hasn't bust display's Player View
                if (Player1.getRunningTotal() < 21)
                {
                    //displays Players view
                    playerView(Player1.getRunningTotal());
                }
                //if player Busts Switches option counter to 2 to exit while loop
                if (Player1.getRunningTotal() > 21)
                {
                    optionCntr = 2;
                }
                //reads the users input
                optionCntr = Convert.ToInt32(Console.ReadLine());

                
            }
           while(optionCntr == 2)
            {

                Console.Clear();
                // bool for player sticking
                playerStick = true;

                // runs until the dealer gets a score greater than 17
                while (dealer1.getRunningTotal() < 17)
                {
                    dealer1.setRunningTotal(dealer1.getRunningTotal() + rand.Next(1, 11));
                }

                //if the dealer's score is 21 or under, dealer sticks and option counter switches to 3 to run the winner or loser while loop 
                if (dealer1.getRunningTotal() <= 21)
                {
                    dealerStick = true;
                    optionCntr = 3;
                }
                //if the dealer's score is greater than 21, dealer busts and option counter switches to 3 to run the winner or loser while loop 
                if (dealer1.getRunningTotal() > 21)
                {
                    dealerBust = true;
                    optionCntr = 3;
                }
            }

            while (optionCntr == 3)
            {
                //dealer and player have stuck
                if (dealerStick == true && playerStick == true)
                {
                    //checks if the dealer or player has the higher score, 

                    //checks if dealer equals or is greater than players 
                    if (dealer1.getRunningTotal() >= Player1.getRunningTotal())
                    {
                        //print appropriate display
                        header();
                        Console.WriteLine("                 YOU LOSE");
                        Console.WriteLine("  Dealer Score   : " + dealer1.getRunningTotal());
                        Console.WriteLine("  Your Score     : " + Player1.getRunningTotal());
                        //exits loop
                        optionCntr = 4;
                    }
                    else
                    //player's score is greater than dealer
                    {
                        header();
                        Console.WriteLine("                 YOU WIN!");
                        Console.WriteLine("  Dealer Score   : " + dealer1.getRunningTotal());
                        Console.WriteLine("  Your Score     : " + Player1.getRunningTotal());
                        optionCntr = 4;
                    }
                }

                // displays appropriate screen if dealer sticks and player busts
                if (dealerStick == true && playerBust == true)
                {
                    header();
                    Console.WriteLine("                 YOU LOSE");
                    Console.WriteLine("  Dealer Score   : " + dealer1.getRunningTotal());
                    Console.WriteLine("  Your Score     : BUST!");
                    // exits loop
                    optionCntr = 4;
                }
                // displays appropriate screen if dealer busts and player sticks
                if (dealerBust == true && playerStick == true)
                {
                    header();
                    Console.WriteLine("                 YOU WIN!");
                    Console.WriteLine("  Dealer Score   : BUST!");
                    Console.WriteLine("  Your Score     : " + Player1.getRunningTotal());
                    // exits loop
                    optionCntr = 4;
                }

                // displays appropriate screen if dealer busts and player busts
                if (dealerBust == true && playerBust == true)
                {
                    header();
                    Console.WriteLine("                 YOU LOSE");
                    Console.WriteLine("  Dealer Score   : BUST!");
                    Console.WriteLine("  Your Score     : BUST!");
                    optionCntr = 4;
                }

            }
            Console.ReadKey();

        }
        /// <summary>
        /// method for quick replication of the header
        /// </summary>
        public static void header()
        {
            Console.WriteLine(" ╔═══════════════════════════════════════╗");
            Console.WriteLine(" ║             ♥♦BLACKJACK♣♦             ║");
            Console.WriteLine(" ╚═══════════════════════════════════════╝");
            Console.WriteLine("");
            
        }
        /// <summary>
        /// Displays the Players interface with current score
        /// </summary>
        /// <param name="pScore">Players Score : int</param>
        public static void playerView(int pScore)
        {
            //stores players new score
            int rTotal = pScore;

            //clears the display for fresh display of new score
            Console.Clear();

            //Displays the users score
            header();
            Console.WriteLine("SCORE : " + rTotal);
            Console.WriteLine("");
            Console.WriteLine(" ╔═══════════════════════════════════════╗");
            Console.WriteLine(" ║ Press (1) to Hit                      ║");
            Console.WriteLine(" ║ Press (2) to Stick                    ║");
            Console.WriteLine(" ╚═══════════════════════════════════════╝");

        }
        
     
    }
}


          
  