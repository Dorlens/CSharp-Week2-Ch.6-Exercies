using static System.Console;

// Write a program named TestScoreList that accepts eight int values representing student test scores. 
// Display each of the values along with a message that indicates how far it is from the average.

class TestScoreList
{
    static void Main()
    {

        int [] Scores  = new int [8];

            int total =0;

        for(int i=0; i<Scores.Length; i++)
            {
                Write("enter test scores: ");
                int userInput = Convert.ToInt32(ReadLine());
                Scores[i] = userInput;
                total += Scores[i];
            }
                
                 

                double average = total/ (double)Scores.Length;

            WriteLine("\nScores and their differences from the average:");

        for (int i = 0; i < Scores.Length; i++)
        {
            double difference = Scores[i] - average;
            WriteLine("Score: {0}, Difference from average: {1:F2}", Scores[i], difference);
        }

    }
}