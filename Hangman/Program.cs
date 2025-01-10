

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
        bool condition = true;
        int numberOfGuesses = 10;
        //As long as the condition is true, the user can enter letters
        while (condition == true)
        {
            Console.Write("Choose a letter: ");
            char userInput = Convert.ToChar(Console.ReadLine().ToLower());

            bool rightGuessed = false;

            for (int i = 0; i < chosenWord.Length; i++)
            {
                if (chosenWord[i] == userInput)
                {
                    letters[i] = userInput;
                    rightGuessed = true;
                }
            }
            Console.WriteLine(string.Join(" ", letters));

            if (!rightGuessed)
                {
                    falseGuesses++;
                    Console.WriteLine("This letter is not contained in the word. You can try " + (numberOfGuesses - falseGuesses) + " times");
                }

                if (!Array.Exists(letters, letter => letter == '_'))
                {
                    Console.WriteLine("Tadaaa. You guessed the word");
                    condition = false;
                    break;
                }

                if (falseGuesses >= numberOfGuesses)
                {
                    Console.WriteLine("You used too many tries. Sorry, you lost");
                    condition = false;
                    break;
                }
        }
    }
}