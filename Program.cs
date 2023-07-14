using System;

class Program
{
    static void Main(string[] args)
    {
        // Here I create a jagged array called studentScores to store the scores of 3 students
        int[][] studentScores = new int[3][];

        // Now insert the studentScores array with the given scores values
        studentScores[0] = new int[] { 85, 92, 78 };
        studentScores[1] = new int[] { 90, 87, 93, 89 };
        studentScores[2] = new int[] { 76, 88 };

        Console.WriteLine("Student Scores:");
        Console.WriteLine("*****************");
        //With nested loops ,Its print the score values of each student here
        
        for (int i = 0; i < studentScores.Length; i++)
        {
            Console.Write("Student {0}: ", i + 1);
            for (int j = 0; j < studentScores[i].Length; j++)
            {
                Console.Write(studentScores[i][j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // here it calculate the average score for each student and its result
        for (int i = 0; i < studentScores.Length; i++)
        {
            int sum = 0;
            for (int j = 0; j < studentScores[i].Length; j++)
            {
                sum += studentScores[i][j];
            }
            double average = (double)sum / studentScores[i].Length;
            Console.WriteLine("Average score for Student {0}: {1}", i + 1, average);
        }

        Console.WriteLine();

        // Now here its calculate the average score for all the students combined and print the final result 
        int totalSum = 0;
        int totalScores = 0;
        for (int i = 0; i < studentScores.Length; i++)
        {
            for (int j = 0; j < studentScores[i].Length; j++)
            {
                totalSum += studentScores[i][j];
                totalScores++;
            }
        }
        double totalAverage = (double)totalSum / totalScores;
        Console.WriteLine("Average score for all students combined: {0}", totalAverage);

        Console.ReadLine();
    }
}