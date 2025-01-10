

class Hangman
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Hangman");
        
        //List that saves the words, that needs to be guessed
        List<String> hangmanWords = new List<string>();
        
        hangmanWords.Add("garage");
        //hangmanWords.Add("Bauzaun");
        //hangmanWords.Add("Bratensoße");
        //hangmanWords.Add("Hemd");
        
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
        Console.Write("Choose a letter: ");
        char userInput = Convert.ToChar(Console.ReadLine().ToLower());
       
        //Run through the word and compare the user input with the existing letters
        bool x = false;
        while (x == false)
        {
            for (int i = 0; i < chosenWord.Length; i++)
            {
                if (chosenWord[i] == userInput)
                {
                    letters[i] = userInput;
                }

                
            }

            Console.WriteLine(string.Join(" ",letters));
            Console.WriteLine("Choose the next letter: "); 
            userInput = Convert.ToChar(Console.ReadLine().ToLower());
        }
            
        
    }
}