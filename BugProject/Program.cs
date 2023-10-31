namespace BugProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NOTE! Remove the return; line below the task once you have fixed the bug, so that you can move to the next task

            Console.WriteLine("Give first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Give last name");
            string lastName = Console.ReadLine();

            //Task 1: Fix the function, so that it prints out the full name correctly
            PrintFullName(firstName, lastName);

            return;

            //Task 2: Fix the Divide function, so that it can handle zero (0)
            // If we try to divide with zero (0), the function should return -1
            double result = Divide(12, 0);

            return;

            int[] numbers = { 1, 2, 3, 4, 5 };

            //Task 3: Fix the CalculateAverage function, so that it calculates the average correctly Korjaa funktion
            double average = CalculateAverage(numbers);

            return;

            Console.WriteLine("Syötä ikä");
            int age = int.Parse(Console.ReadLine());

            //Task 4; Fix the DeterminiteGeneration function, so that it prints out the correct generation if the age is 59
            DeterminiteGeneration(age);

            return;

            //Task 5: Fix the PrintPlanetNames function so that it works correctly
            PrintPlanetNames();

            return;

        }

        public static void PrintFullName(string firstName, string lastName)
        {
            Console.WriteLine(firstName + lastName);
        }

        public static double CalculateAverage(int[] numbers)
        {
            double sum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum / numbers.Length;
        }

        public static double Divide(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                return -1;
            }
            else
            {
                return a / b;
            }
        }

        public static void DeterminiteGeneration(int age)
        {
            if (age >= 0 && age <= 13)
            {
                Console.WriteLine("You belong to Gen Alpha (Alpha) generation.");
            }
            else if (age >= 14 && age <= 28)
            {
                Console.WriteLine("You belong to Gen Z (Z-generation) generation.");
            }
            else if (age >= 29 && age >= 43)
            {
                Console.WriteLine("You belong to Millennials (Y) generation.");
            }
            else if (age >= 44 || age <= 58)
            {
                Console.WriteLine("You belong to Gen X (X-generation) generation.");
            }
            else if (age >= 59 && age <= 77)
            {
                Console.WriteLine("You belong to Baby Boomers generation.");
            }
            else
            {
                Console.WriteLine("You don't belong to any of the above mentioned generations.");
            }
        }

        public static void PrintPlanetNames()
        {
            string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
            for (int i = 0; i <= planets.Length; i++)
            {
                Console.WriteLine(planets[i]);
            }
        }

    }
}