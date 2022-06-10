int length = GetNumberInput();
string[]words = PopulateWordArray(length);
Char charToCount = GetCharacterInput();
int charFrequency = CountCharacters(words, charToCount);
Console.WriteLine($"frequency: {charFrequency}");
double charPercentage = GetCharacterOcurrencePercentage(words, charToCount);
Console.WriteLine($"percentage: {charPercentage}");
PrintResults(charToCount, charFrequency, charPercentage);

int GetNumberInput()
{
    Console.WriteLine("Please enter a number");
    return Int32.Parse(Console.ReadLine());
}


string[] PopulateWordArray(int length)
{
    string[] wordList = new string[length];
    Console.WriteLine($"please enter {length} words");
    for (int i = 0; i < wordList.Length; i++)
    {
        string wordinput = Console.ReadLine();
        if (!wordinput.Any(Char.IsWhiteSpace))
        {
            wordList[i] = wordinput;
        }
        else
        {
            i--;
        }
    }
    return wordList;
}


char GetCharacterInput()
{
    Console.WriteLine("Please enter a character");
    return Char.Parse(Console.ReadLine());
}


int CountCharacters(string[] words, char charToCount)
{
    int totalChars = 0;
    int countedCharacter = 0;  
    string oneWord = "";

    for (int i = 0; i < words.Length; i++)   
    {
        oneWord = string.Join("", words);
    }

    totalChars += oneWord.Length;
    
    for (int i = 0; i < oneWord.Length; i++)  
    {
        if (oneWord[i].Equals(charToCount))
        {
            countedCharacter++;
        }
    }
    return countedCharacter;
}


double GetCharacterOcurrencePercentage(string[] words, char charToCount)
{
    double totalChars = 0;
    double countedCharacter = 0;
    string oneWord = "";
    

    for (int i = 0; i < words.Length; i++)
    {
        oneWord = string.Join("", words);
    }

    totalChars += oneWord.Length;
    
    for (int i = 0; i < oneWord.Length; i++)
    {
        if (oneWord[i].Equals(charToCount))
        {
            countedCharacter++;
        }
    }

    double percentage = (countedCharacter / totalChars) * 100;

    return percentage;
}


void PrintResults(char charToCount, int charFrequency, double charPercentage)
{
    if (charFrequency == 1)
    {
        Console.WriteLine($"\nThe character {charToCount} appears {charFrequency} time in the array.");
    }
    else if (charFrequency > 1 && charPercentage < 25)
    {
        Console.WriteLine($"\nThe character {charToCount} appears {charFrequency} times in the array.");
    }
    else if (charFrequency > 1 && charPercentage >= 25)
    {
        Console.WriteLine($"\nThe character {charToCount} appears {charFrequency} times in the array. This letter makes up more than {charPercentage}% of the total number of characters.");
    }
}




