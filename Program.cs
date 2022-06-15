List<List<int>> allLists = new List<List<int>>();
allLists.Add(new List<int> { 1, 5, 3} );
allLists.Add(new List<int> { 9, 7, 3, -2 });
allLists.Add(new List<int> { 2, 1, 2 });

List<List<int>> gradesStudents = new List<List<int>>();
gradesStudents.Add(new List<int> { 85, 92, 67, 94, 94 });
gradesStudents.Add(new List<int> { 50, 60, 57, 95 });
gradesStudents.Add(new List<int> { 95 });

Console.WriteLine(MaxNumbersInLists(allLists));
Console.WriteLine(HighestGrade(gradesStudents));

List<int> MaxNumbersInLists(List<List<int>> allLists)
{
    List<int> greatestNumbers = new List<int>();

    foreach (List<int> findMax in allLists)
    {
        greatestNumbers.Add(findMax.Max());
    }

    Console.WriteLine(String.Join(", ", greatestNumbers));

    Console.WriteLine($"List 1 has a maximum of {greatestNumbers[0]}. List 2 has a maximum of {greatestNumbers[1]}. List 3 has a maximum of {greatestNumbers[2]}.");
 
    return greatestNumbers;
}


string HighestGrade(List<List<int>> gradesStudents)
{
    List<int> bestGrades = new List<int>();
    int maxGrade = int.MinValue;
    int classes = 0;

    foreach (List<int> grade in gradesStudents)
    {
        bestGrades.Add(grade.Max());
    }

    foreach (int best in bestGrades)
    {
        if (best > maxGrade)
        {
            maxGrade = best;
        }
    }

    //foreach (List<int> searchGrade in gradesStudents)
    //{
    //    if (maxGrade.Equals(searchGrade))
    //    {
    //        classes.Add(searchGrade);
    //    }
    //}

    Console.WriteLine($"The Highest grade is {maxGrade}");

    return maxGrade.ToString();
}