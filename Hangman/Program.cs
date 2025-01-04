

class Hangman
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Hangman");
        
        //List that saves the words, that needs to be guessed
        List<String> hangmanWords = new List<string>();
        
        hangmanWords.Add("Garage");
        //hangmanWords.Add("Bauzaun");
        //hangmanWords.Add("Bratensoße");
        //hangmanWords.Add("Hemd");
        
        //Randomly a word is being chosen
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, hangmanWords.Count-1);
        
        String chosenWord = hangmanWords[randomNumber];
        Char[] letters = new Char[chosenWord.Length];

        for (int i = 0; i < letters.Length; i++)
        {
            letters[i] = '_';
        }
        
        Console.WriteLine("The word you have to guess has " + chosenWord.Length + " letters");
        Console.Write("Choose a letter: ");
        char userInput = Convert.ToChar(Console.ReadLine());
       
        //Run through the word and compare the user input with the existing letters
        for(int i = 0; i < chosenWord.Length; i++)
        {
            if (chosenWord[i] == userInput)
            {
                letters[i] = userInput;
            }
            
            
        }
        Console.WriteLine(string.Join(" ",letters));
        
        
            
        
    }
}