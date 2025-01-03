

class Hangman
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Hangman");
        
        //List that saves the words, that needs to be guessed
        List<String> hangmanWords = new List<string>();
        
        hangmanWords.Add("Garage");
        hangmanWords.Add("Bauzaun");
        hangmanWords.Add("Bratensoße");
        hangmanWords.Add("Hemd");
        
        //Randomly a word is being chosen
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, hangmanWords.Count-1);
        
        String chosenWord = hangmanWords[randomNumber];
        Console.WriteLine("The word you have to guess has " + chosenWord.Length + " letters");
        Console.Write("Choose a letter: ");
        char userInput = Convert.ToChar(Console.ReadLine());
        foreach (char letter in chosenWord)
        {
            if (letter == userInput)
            {
                Console.Write(userInput + " ");
            }
            else
            {
                Console.Write("_ ");
            }
            
        }
        
        
            
        
    }
}