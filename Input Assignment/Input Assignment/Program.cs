// Import necessary namespaces for file handling and input/output operations
using System;
using System.IO;  // Required for working with files (File.WriteAllText, File.ReadAllText)

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to input a number
            Console.WriteLine("Please enter a number:");

            // Store the user's input in a string variable (input will be treated as text)
            string userInput = Console.ReadLine();

            // Define the path where the text file will be created/stored
            // This will save the file in the same folder where the application is running
            string filePath = "userInput.txt";

            // Write the user's input to the text file
            // File.WriteAllText will create the file if it doesn't exist and write the content
            File.WriteAllText(filePath, userInput);

            // Read the contents of the text file to confirm the written data
            // File.ReadAllText reads the entire content of the file
            string fileContent = File.ReadAllText(filePath);

            // Output the content of the file back to the user
            Console.WriteLine("The number you entered is: " + fileContent);

            // Keep the console open until the user presses a key (to allow them to see the result)
            Console.ReadKey();
        }
    }
}
