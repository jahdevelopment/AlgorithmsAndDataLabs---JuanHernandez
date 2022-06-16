// List for test the first case:
List<List<int>> allLists = new List<List<int>>();
allLists.Add(new List<int> { 1, 5, 3} );
allLists.Add(new List<int> { 9, 7, 3, -2 });
allLists.Add(new List<int> { 2, 1, 2 });

// List for test the second case:
List<List<int>> gradesStudents = new List<List<int>>();
gradesStudents.Add(new List<int> { 85, 92, 67, 94, 94 });
gradesStudents.Add(new List<int> { 50, 60, 57, 95 });
gradesStudents.Add(new List<int> { 95 });

Console.WriteLine(MaxNumbersInLists(allLists)); // calling the fist case
Console.WriteLine(HighestGrade(gradesStudents)); // calling the second case


//////////++++ FIRST CASE ++++///////////

/* Method who receives a List with nested lists, and give as a output 
 * another list with the highest number of each nested list. 
 * Also prints a paragraph with some details of the results.
 */
List<int> MaxNumbersInLists(List<List<int>> allLists)
{
    List<int> greatestNumbers = new List<int>(); // This is the list that we fill for the output

    /* The next foreach iterates betweeen each nested list and returns the maximum number of each.
     * The result is saved in the list "gratestNumbers".
     */
    foreach (List<int> findMax in allLists) 
    {
        greatestNumbers.Add(findMax.Max());
    }

    // With the Join method, we concatenate and print the results stored previously. 
    Console.WriteLine(String.Join(", ", greatestNumbers));

    // Finally we print the results in a paragraph for a better understanding of each number.
    Console.WriteLine($"List 1 has a maximum of {greatestNumbers[0]}. List 2 has a maximum of {greatestNumbers[1]}. List 3 has a maximum of {greatestNumbers[2]}.");
 
    return greatestNumbers;
}


//////////++++ SECOND CASE ++++///////////

/*Method which receives a a parameter a list with nested lists
* and output the highest number of every nested lists*/

string HighestGrade(List<List<int>> gradesStudents)
{
    // The next list is going to receive the max number of each nested list.
    List<int> bestGrades = new List<int>();
    int minValue = int.MinValue; // Integer which receives the minimum value possible of the integers
    int maxGrade = 0; //Integer to store the maximum value total of all the grades 
    
    // Foreach to add the max value of each nested list and store the values in the list "bestGrades"
    foreach (List<int> grade in gradesStudents)
    {
        bestGrades.Add(grade.Max());
    }

    /* Foreach to iterate and compare the maximum value between each of the highest values 
     * stored in the "bestGrades" list with the minimun value "minValue", and add the result 
     * in the "maxGrade" variable.
     */ 
    foreach (int best in bestGrades)
    {
        if (best > minValue)
        {
            maxGrade = best;
        }
    }

   
    // Print the result with a small message
    Console.WriteLine($"The Highest grade is {maxGrade}");

    return maxGrade.ToString();
}