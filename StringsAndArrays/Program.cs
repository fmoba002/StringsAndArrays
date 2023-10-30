namespace StringsAndArrays
{
    class Program
    {
        // INSTRUCTIONS: Write you task related code answers under each specific comment/insturction
        static void Main(string[] args)
        {
            // PART 1: Strings

            // 1. Basic String Operations
            string helloWorld = "Hello, World!";

            // 1.1 Print the length of the string.

            Console.WriteLine("Length of the string: " + helloWorld.Length);

            // 1.2 Print the first and the last character of the string.

            Console.WriteLine("First character: " + helloWorld[0]);
            Console.WriteLine("Last character: " + helloWorld[11]);

            // 2. String Manipulation

            Console.Write("Please enter your name: ");
            // 2.1 Get the input from and assing it into new string variable called name

            string name = Console.ReadLine();

            // 2.2 Print a personalized welcome message including the name.

            Console.WriteLine("Hello, " + name + "!");

            // 2.3 Convert name variable to uppercase and output the result

            string upperCaseName = name.ToUpper();
            Console.WriteLine("Uppercase Name: " + upperCaseName);

            // 2.4 Convert name variable to lowercase and output the result

            string lowerCaseName = name.ToLower();
            Console.WriteLine("Lowercase Name: " + lowerCaseName);

            // 3. String Searching in
            // 3.1 Create new boolean variable called containsWorld

            bool containsWorld;

            // 3.2 Check that the helloWorld variable contains the word "World".
            //     Assign the result to the created constainsWorld variable

          
            containsWorld = helloWorld.Contains("World", StringComparison.OrdinalIgnoreCase);

            // 3.3 If the word is found, get the index of the word from helloWorld string

            if (containsWorld)
            {
                int index = helloWorld.IndexOf("World", StringComparison.OrdinalIgnoreCase);
                Console.WriteLine("The word 'World' was found at index: " + index);
            }
            else
            {
                Console.WriteLine("The word 'World' was not found in the helloWorld string.");
            }

            // PART 2: Arrays In C#

            // 1. Basic Array Operations
            // 1.1 initialize array called numbers containing array of int values
            //     Add these values to the array -> 2 3 5 7 11 

            int [] numbers = { 2, 3, 5, 7, 11 };

            // 1.2 Output the numbers array -> hint use Join
            // Expected outcome: 2, 3, 5, 7, 11

            Console.WriteLine("Output the numbers array:");
            Console.WriteLine(string.Join(", ", numbers));

            // 1.3 Output the value of the third (3th) item in the numbers array 
            // Expected outcome: 5

            Console.WriteLine("Output the value of the third item in the numbers array:");
            Console.WriteLine(numbers[2]);


            // 2. Array Manipulation 
            Console.WriteLine("Please enter five names:");
            // 2.1 Initialize new names string array variable that has room for 5 items
            //     The maximum lenght of the string array should be 5

            string[] names = new string[5];

            // 2.2 Ask the user to input new names 5 times
            //     and assing each name to the names string array in the given order.
            //     The first name should be at index 0
            //     Hint: you might want to use some sort of a loop here

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter name {i + 1}: ");
                names[i] = Console.ReadLine();
            }

            // 2.3 Output the array of given names.

            Console.WriteLine("Output the array of given names:");
            Console.WriteLine(string.Join(" ", names));

            // 2.4 Reverse the order of the items in the names array and outpu the result

            Console.WriteLine("Reverse the order of the items in the names array:");
           // Array.Reverse(names);
           // Console.WriteLine(string.Join(" ", names));

            string[] reversedNames = (string[])names.Clone(); // Another solution so it won't effect the Array searching in 3.1 
            Array.Reverse(reversedNames);
            Console.WriteLine(string.Join(" ", reversedNames));

            // 3. Array Searching

            Console.Write("Please enter a name to search: ");

            string searchName = Console.ReadLine();

            // 3.1 Try to find out the searchName from the Task 2 names string array
            //     by finding out it's index.
            //     Assign the index value to new position integer variable

            int position = Array.IndexOf(names, searchName);

            // 3.2 Check that the index position was found
            //     Hint: What is the result of IndexOf if nothing is found
            // 3.2.1 If position is found output the searchName and the found position
            // 3.2.2 Else output that the searchName was not found

            if (position != -1)
            {
                
                Console.WriteLine($"The name {searchName} was found at position {position +1 }.");
            }
            else
            {
                
                Console.WriteLine($"The name {searchName} was not found in the array.");
            }

            // 4. BONUS

            // 1. String to Array
            // 1.1 Create new empty words string array

            string[] words;

            // 1.2 Try to get each word from the helloWorld variable and assing the values to
            //     the created words string array

            words = helloWorld.Split(' ');

            // 1.3 Output the values of the words array

            Console.WriteLine("Words in the array: " + string.Join(" ", words));
        }
    }
}
