using System;

namespace IfChallenge2_HighScore
{
    class Program
    {
        static int highscore = 300;
        static string highscorePlayer = "Jocke";
         
        void Main(string[] args)
        {
            CheckHighscore(250, "Olof");
            CheckHighscore(315, "Jocke");
            CheckHighscore(400, "Jocke");
             
            Console.Read();
        }

        public static void CheckHighscore(int score, string playerName)
        {
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New Highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore could not be broken! It is still " + highscore + " and held by " + highscorePlayer);
            }
        }
    }    
}