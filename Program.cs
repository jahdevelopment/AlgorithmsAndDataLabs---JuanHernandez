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

char[] DuplicateCharacters(string testString)
{

    //char [] repeated = new char[];

    for(int i = 0; i < testString.Length; i++)
    {
        
    }

    return repeated;
}