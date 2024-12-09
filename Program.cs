using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string filePath = "data.csv"; // Path to the CSV file
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Error: File not found.");
            return;
        }
        // Define a fixed-size 2D array (3 rows and 3 columns)
        int[,] matrix = new int[3, 3];
        // Read all lines from the file
        string[] lines = File.ReadAllLines(filePath);
        // Parse each line into the 2D array
        for (int i = 0; i < lines.Length; i++) // Loop through each line
        {
            string[] values = lines[i].Split(','); // Split the line by commas
            for (int j = 0; j < values.Length; j++) // Loop through each value in
                the line
        {
                matrix[i, j] = int.Parse(values[j]); // Convert to integer and
                store in the array
 }
        }
        // Print the 2D array to verify
        Console.WriteLine("The contents of the matrix are:");
        for (int i = 0; i < matrix.GetLength(0); i++) // Loop through rows
        {
            for (int j = 0; j < matrix.GetLength(1); j++) // Loop through columns
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine(); // New line after each row
        }
    }
}