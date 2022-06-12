//Making a call of all of the functions consecutively 
int length = GetNumberInput();
string[]stringOfWords = PopulateWordArray(length);
Char charToCount = GetCharacterInput();
string words = addingWords(stringOfWords);
int charFrequency = CountCharacters(words, charToCount);
double charPercentage = GetCharacterOcurrencePercentage(words, charFrequency);
PrintResults(charToCount, charFrequency, charPercentage);


//Using the console, we ask the user for the number or words that the array is going to have, this function return the answer 
int GetNumberInput()
{
    Console.WriteLine("Please enter a number");
    return Int32.Parse(Console.ReadLine());
}


// With this function we make a request to the user for writting the words depending by the number he said previously.
// With a foor loop we place each word in a string, and all is going to be stored in an array called WordList wich is te return of this function
string[] PopulateWordArray(int length)
{
    string[] wordList = new string[length];
    Console.WriteLine($"please enter {length} words");
    for (int i = 0; i < wordList.Length; i++)
    {
        string wordInput = Console.ReadLine();
        if (!wordInput.Any(Char.IsWhiteSpace))
        {
            wordList[i] = wordInput;
        }
        else
        {
            i--;
        }
    }
    return wordList;
}


//Using the console, we ask the user for the character that we are going to search in the array
//this function return the answer converted to a Lower Case leter in the case the user prompt it in Upper Case
char GetCharacterInput()
{
    Console.WriteLine("Please enter a character");
    Char leter = Char.Parse(Console.ReadLine());
    Char leter1 = char.ToLower(leter);
    return leter1;
}


//Using a foor loop we iterate into the array when the words are stored, and we make a concatenation or each of them in just one string
string addingWords(string[] stringOfWords)
{
    string oneWord = "";

    for (int i = 0; i < stringOfWords.Length; i++)
    {
        oneWord = string.Join("", stringOfWords);
    }
    string wordInLower = oneWord.ToLower();
    return wordInLower;
}


//With the for loop we iterate in the new string and compare the character given by the user with each leter in the string called words which contains the return of the above function,
//in the case there are both equals we are adding a unit in the countedCharacter variable, this is the return of ConuntCharacters function
int CountCharacters(string words, char charToCount)
{
    int countedCharacter = 0;  
            
    for (int i = 0; i < words.Length; i++)  
    {
        if (words[i].Equals(charToCount))
        {
            countedCharacter++;
        }
    }
    return countedCharacter;
}


// this function brings the return of the CountCharacters function into the chatFrecuency variable,
// we calculate the number of characters present in the string words with the use of Length property
// finally we calculate and return the percentage with the use of charFrequency and totalChars
double GetCharacterOcurrencePercentage(string words,int charFrequency)
{
    double totalChars = 0;

    totalChars = words.Length;
    
    double percentage = Math.Round((charFrequency / totalChars) * 100);

    return percentage;
}


// Based on the frequency and percenate of appearance of the leter we search in the string,
// we run different messages, one when the letter apears jus one time,
// another betweeen 2 and 25% of appearance
// the thir messsage is in the case the letter is up more than 25% of appearance
// the lats messaje is in the case the leter was not found in the searching
void PrintResults(char charToCount, int charFrequency, double charPercentage)
{
    if (charFrequency == 1)
    {
        Console.WriteLine($"\nThe character {charToCount} appears {charFrequency} time in the array.");
    }
    else if (charFrequency > 1 && charPercentage < 25)
    {
        Console.WriteLine($"\nThe character {charToCount} appears {charFrequency} times in the array.This is the {charPercentage}% of the total number of characters.");
    }
    else if (charFrequency > 1 && charPercentage >= 25)
    {
        Console.WriteLine($"\nThe character {charToCount} appears {charFrequency} times in the array. This letter makes up more than 25% of the total number of characters.");
    }
    else
    {
        Console.WriteLine("the character does not appear in the list ot words that you wrote");
    }
}




