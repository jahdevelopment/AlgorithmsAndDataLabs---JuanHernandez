
// Make a request for the number of total words the array will be have

Console.WriteLine("Please enter a number");

int n = int.Parse(Console.ReadLine());

string[] wordList = new string[n];


// get the word list  

Console.WriteLine("Please enter {0} words", n);

for (int i = 0; i < wordList.Length; i++)
{
    string wordInput = Console.ReadLine();

    if (!wordInput.Any(Char.IsWhiteSpace))  // if the input has no white spaces , add to the "wordInput", else it will ask again 
    {
        wordList[i] = wordInput;
    }
    else
    {
        i--;
    }
}

// get the caracter that we want to search in the array

Console.WriteLine("Please enter a character");
char askedCharacter = Console.ReadKey().KeyChar;

double characterTotal = 0;  // for counting the total of characters in the string
double characterCount = 0;  // for counting the total of repetitions of the character that we search into the string
string oneWord = "";

for (int i = 0; i < wordList.Length; i++)   // this for loop joins all the strings in just one single string
{
    oneWord = string.Join("", wordList);
}

characterTotal += oneWord.Length;

for (int i = 0; i < oneWord.Length; i++)   // This for loop search the character into the string and counts the times it is repeated
{
    if (oneWord[i].Equals(askedCharacter))
    {
        characterCount++;
    }
}


double percentage = (characterCount / characterTotal) * 100;  // Calculate the percentage of repetitions of the character searched in the string

if (characterCount == 1)   // if stattemen for setting the results
{
    Console.WriteLine($"\nThe character {askedCharacter} appears {characterCount} time in the array.");
}
else if (characterCount > 1 && percentage < 25)
{
    Console.WriteLine($"\nThe character {askedCharacter} appears {characterCount} times in the array.");
}
else if (characterCount > 1 && percentage >= 25)
{
    Console.WriteLine($"\nThe character {askedCharacter} appears {characterCount} times in the array. This letter makes up more than {Math.Round(percentage)}% of the total number of characters.");
}
