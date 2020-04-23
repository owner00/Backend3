using System;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to owner00's number guessing game");
            Console.Write("Input 1 for easy, 2 for medium or 3 for hard : ");
            int level;
            try{
                level = int.Parse(Console.ReadLine());
            }
            catch(FormatException fe) {
                Console.WriteLine("You have inputted an invalid number. Restart the game!");
                Console.WriteLine("This is the Error Message " + fe.Message);
                return;
            }
            
            bool hasUserGottenAnswer = false;
            if(level == 1) {
                int limit = 10;
                int guesses = 6;
                hasUserGottenAnswer = numberGuesser(limit, guesses);
            }
            else if(level == 2) {
                int limit = 20;
                int guesses = 4;
                hasUserGottenAnswer = numberGuesser(limit, guesses);
            }
            else if(level == 3) {
                int limit = 50;
                int guesses = 4;
                hasUserGottenAnswer = numberGuesser(limit, guesses);
            }
            else {
                Console.WriteLine("Sorry! You have inputted an invalid number."
                + "\nTry again!");
            }
            if(hasUserGottenAnswer == false){
                Console.WriteLine("Game Over!");
            }
        }

        public static bool numberGuesser(int limit, int guesses) {
            Random random = new Random();
            int answer = random.Next(limit) + 1;
            //Console.WriteLine("The answer is " + answer);
            bool result = false;
            int remainingGuesses = guesses;
            for(int i = 0;i<guesses;i++) {
                Console.Write("Guess a number between 1 and "+limit+" : ");
                int userInput;
                try{
                    userInput = int.Parse(Console.ReadLine());
                }
                catch(FormatException fe) {
                    Console.WriteLine("You have inputted an invalid number. Restart the game!");
                    Console.WriteLine("This is the Error Message " + fe.Message);
                    return false;
                }
                
                if(userInput == answer) {
                    Console.WriteLine("You got it right!");
                    result = true;
                    break;
                }
                else {
                    remainingGuesses--;
                    Console.WriteLine("That was wrong");
                    Console.WriteLine("Your Remaining Guesses are : " + remainingGuesses);
                }
            }
            return result;
        }
    }
}
