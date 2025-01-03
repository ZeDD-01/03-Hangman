

class Hangman
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        List<String> hangmanWords = new List<string>();
        
        hangmanWords.Add("Garage");
        hangmanWords.Add("Bauzaun");
        hangmanWords.Add("Bratensoße");
        
        List<String> meineListe = new List<string>();
        
        meineListe.Add("Peter");
        meineListe.Add("Sara");
        meineListe.Add("Ute");
        meineListe.Add("Hans");

        foreach (string names in meineListe)
        {
            Console.WriteLine(names);
        }
        
        
    }
}