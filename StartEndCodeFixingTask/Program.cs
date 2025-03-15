namespace StartEndCodeFixingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The algorithm in the Readme contains an error
            // Rewrite the algorithm in C# bellow fixing the error
            // Show the test outputs for the test table in the Readme
            // Put your evidence where it says Do the coding task in C#

            bool validChoice = true;
            int difference = -1;
            int endYear=0;
            int startYear=0;
            do
            {
                validChoice = true;
                Console.WriteLine("Enter a start year");
                startYear = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter an end year");
                endYear = Convert.ToInt32(Console.ReadLine());
                if (startYear >= endYear)
                {
                    Console.WriteLine("Start year must be before end year");
                    validChoice = false;
                }
                else if(startYear > 2000)
                {
                    Console.WriteLine("Start year must be before 2000");
                    validChoice = false;
                }
               

            } while (validChoice == false);
            difference = endYear - startYear;
            Console.WriteLine(difference);


        }
    }
}
