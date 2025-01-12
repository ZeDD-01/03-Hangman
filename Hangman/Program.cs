

using System;

class Hangman
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Hangman");
        
        //List that saves the words, that needs to be guessed
        List<String> hangmanWords = new List<string>();
        
        hangmanWords.Add("garage");
        hangmanWords.Add("bauzaun");
        hangmanWords.Add("bratensosse");
        hangmanWords.Add("hemd");
        
        //Randomly a word is being chosen
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, hangmanWords.Count-1);
        
        //An array is being created and filled with underscrore characters.
        String chosenWord = hangmanWords[randomNumber];
        Char[] letters = new Char[chosenWord.Length];

        for (int i = 0; i < letters.Length; i++)
        {
            letters[i] = '_';
        }
        
        Console.WriteLine("The word you have to guess has " + chosenWord.Length + " letters");
        Console.WriteLine(chosenWord);
       
        int falseGuesses = 0;
        bool continueUserInput = true;
        const int NUMBER_OF_GUESSES = 10;
        
        //As long as the condition is true, the user can enter letters
        while (continueUserInput)
        {
            Console.Write("Choose a letter: ");
            ConsoleKeyInfo userInputKey = Console.ReadKey();
            char userInput = userInputKey.KeyChar;
           
            bool rightGuessed = false;
            
            if (chosenWord.Contains(userInput))
            {
                Console.WriteLine("You got the letter! ");
                for (int i = 0; i < chosenWord.Length; i++)
                {
                    if (chosenWord[i] == userInput)
                    {
                        letters[i] = userInput;
                        rightGuessed = true;
                    }
                }
            }
            
            Console.WriteLine(string.Join(" ", letters));

            if (!rightGuessed)
                {
                    falseGuesses++;
                    Console.WriteLine("This letter is not contained in the word. You can try " + (NUMBER_OF_GUESSES - falseGuesses) + " times");
                }

            if (!Array.Exists(letters, letter => letter == '_'))
                {
                    Console.WriteLine("Tadaaa. You guessed the word");
                    continueUserInput = false;
                    break;
                }

            if (falseGuesses >= NUMBER_OF_GUESSES)
                {
                    Console.WriteLine("You used too many tries. Sorry, you lost");
                    continueUserInput = false;
                    break;
                }
        }
    }
}