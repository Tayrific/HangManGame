namespace HangManGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-------Welcome to Hang Man---------");
            Console.WriteLine("--Press any key to start the game--");
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Please enter a word for the other player to guess:");
            string word = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("The word has been entered. Now it's time for the other player to guess the word.");

            string[] wordArray = new string[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                wordArray[i] = "_";
            }

            for (int i = 0; i < wordArray.Length; i++)
            {
                Console.Write(wordArray[i] + " ");
            }

            int lives = 8;

            Console.WriteLine("\n\nLives: " + lives);

            while (lives != 0)
            {
                Console.WriteLine("\n\nPlease enter a letter to guess the word:");
                string letter = Console.ReadLine();
                Console.Clear();
                bool letterFound = false;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i].ToString() == letter)
                    {
                        wordArray[i] = letter;
                        letterFound = true;
                    }
                }

                if (letterFound == false)
                {
                    lives--;
                }

                for (int i = 0; i < wordArray.Length; i++)
                {
                    Console.Write(wordArray[i] + " ");
                }

                Console.WriteLine("\n\nLives: " + lives);

                if (lives == 0)
                {
                    Console.WriteLine("\n\nYou have run out of lives. The word was: " + word);
                    Console.WriteLine("\n\nPress any key to exit the game.");
                    Console.ReadKey();
                    break;
                }

                bool wordGuessed = true;

                for (int i = 0; i < wordArray.Length; i++)
                {
                    if (wordArray[i] == "_")
                    {
                        wordGuessed = false;
                    }
                }

                if (wordGuessed == true)
                {
                    Console.WriteLine("\n\nCongratulations! You have guessed the word: " + word);
                    Console.WriteLine("\n\nPress any key to exit the game.");
                    Console.ReadKey();
                    break;
                }
            }
          
        }
    }
}
