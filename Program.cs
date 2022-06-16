// We ask for console the user for a word in order to know if it is plaindrome
// the input of the user will be kept in a varible string calle testString
Console.WriteLine("Please give me a word");
string testString = Console.ReadLine();


// With an if statement we first evaluate if the input does not have spaces for continue running the program,
// otherwise the console will make a comment indicating "Please give me only one word, start again"

if (!testString.Contains(" "))
{
    Console.WriteLine(IsPalindrome(testString)); // Here we call the funtion below with the return we need to know
    
    bool IsPalindrome(string testString)
    {
        // First we create another string for keeping the same world, but in this case it will be writed in reverse order
        // With a for loop we iterate the word gived by the user from the last inder to the first, and add to the new string called "toCompare"
        string toCompare = "";
        for (int i = testString.Length - 1; i >= 0; i--)
        {
            toCompare += testString[i];
        }
        // In this section we compare equality between the word given by the user with the new word created in the new string
        // if there are equals the functio will retur True, otherwise  returr False
        if (toCompare.Equals(testString))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
else
{
    Console.WriteLine("Please give me only one word, start again");
}


////////////////////*****SECOND PART*****////////////////////////////

//We request the array of characters to compress and store in a string called "characters"
Console.WriteLine("Please write the characters");
string characters = Console.ReadLine();

Console.WriteLine(SearchDuplicates(characters));

/* With this function we are going to select only the duplicate characters and store in a
new array of chars */
char[] SearchDuplicates(string characters)
{
    /*We take the string we received as a parameter, the letters are converted to upper case
    and stored in a new array of characters,*/ 
    char [] repeated = characters.ToUpper().ToCharArray();

    /*With a dictionay we are to organize the information of the characters giving the name 
    of the characters as a Key and the number of repetitions as Value 
      */
    Dictionary<char, int> charAndNumber = new Dictionary<char, int>();

    //the next for each populate the dictionary with the characters and his number of repetitions
    foreach (char chars in repeated)
    {
        if (charAndNumber.ContainsKey(chars))
        {
            charAndNumber[chars]++;
        }
        else
        {
            charAndNumber.Add(chars, 1);
        }
    }

    /*The next array of chars will be storing the characters repeated*/
    char[] charsOutput = new char[charAndNumber.Count];
    int counter = 0;

    /*This foreach is for populate the charsOutput array conditionated
    to the characters present more than once*/ 
    foreach (KeyValuePair<char, int> kvp in charAndNumber)
    {
        if (kvp.Value > 1)
        {
            charsOutput[counter] = kvp.Key;
            counter++;
        }
        else
        {
            Array.Resize(ref charsOutput, charsOutput.Length - 1);
        }
    }

    return charsOutput;
}