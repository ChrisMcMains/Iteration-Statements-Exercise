namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        static void PrintNumbers1000ToNegative1000()
        {
            for (int i = 1000; i >= -1000; i--) ;
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        static void PrintNumbersByThree()
        {
            for (int i = 3; i <= 999; i += 3) ;
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        static bool AreEqual(int number1, int number2)
        {
            return number1 == number2;
        }
        //Write a method to check whether a given number is even or odd
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        //Write a method to check whether a given number is positive or negative
        static bool IsPositive(int number)
        {
            return number > 0;
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        static bool CanVote(int age)
        {
            int votingAge = 18;
            return age >= votingAge;
        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        static bool IsInRange(int number)
        {
            return (number >= -10 && number < +10);
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        static void DisplayMultiplicationTable(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"Multiplication table for {num}");
                Console.WriteLine($"{num} x {i} = {num * i}");
            }

        }
        //Call the methods to test them in the Main method below
        static void Main(string[] args)

        {
            Console.WriteLine("Enter a number");
            int number;

            if (int.TryParse(Console.ReadLine(), out number))

            {
                if (IsInRange(number))
                {
                    Console.WriteLine($"{number} is within -10 to 10.");
                }
                else
                {
                    Console.WriteLine($"{number} is not within -10 to 10");
                }

            }

            else
            {
                Console.WriteLine("Invalid input.  Please enter a vaild number.");
            }
            
                Console.WriteLine("Enter a number");
                int num;
            
            if (int.TryParse(Console.ReadLine(), out num)) 
                
            {
                DisplayMultiplicationTable(num);
            }
            else 
            {
                Console.WriteLine("Invalid input.  Please enter a valid number.");
            }
             
            
            
        }
    }
}
