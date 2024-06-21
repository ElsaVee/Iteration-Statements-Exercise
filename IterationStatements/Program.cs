using System.Net.Security;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000 - DONE
         public static void ReverseNumbers()
        
        {
            int numDown = 1000;
            do
            {
               Console.WriteLine(numDown);
               numDown--;
            }
            while (numDown >= -1000);
           
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time - DONE
        public static void ByThrees()

        {
            int threes =3;

            while (threes <= 999) 
            {
                
                Console.WriteLine(threes);
                threes += 3;
                               
            }
                       
        }


        //Write a method to accept two integers as parameterss and check whether they are equal or not - Done
        public static void EqualOrNot()
        {
            Console.WriteLine("Please give me two integers");
            var intOne = Console.ReadLine();
            var intTwo = Console.ReadLine();

            if (intOne == intTwo) Console.WriteLine("Your integers are equal!");
            else Console.WriteLine("They are not equal.");

        }

        //Write a method to check whether a given number is even or odd - DONE
        public static void OddOrEven()
        {
            Console.WriteLine("I can tell you if your number is odd or even. Give me a number:");
            var userNum = int.Parse(Console.ReadLine());
           
            if (userNum %2 == 0)
            {
                Console.WriteLine("Your number is even.");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }

        }

        //Write a method to check whether a given number is positive or negative - DONE
        public static void PosOrNeg()
        {
            Console.WriteLine("Hello! How much money is in your account today?");
            var bankFunds = int.Parse(Console.ReadLine());
                
            if (bankFunds >= 0) 
            {
                Console.WriteLine("You are in the black!");
            }
            else
            {
                Console.WriteLine("Uh-oh! The dreaded red :(");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote. - DONE
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void VoterEligible()
        {
            Console.WriteLine("Hello! Are you old enough to vote? Please enter your age:");
            var voterAge = int.Parse(Console.ReadLine());
            if (voterAge >= 18) 
            {
                Console.WriteLine($"Congratulations! {voterAge} is old enough to vote!");
            }
            else
            {
                Console.WriteLine($"Well, {voterAge} isn't quite old enough, yet. See you soonish");
            }
        }


        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void FindMyRange()
        {
            Console.WriteLine($"Enter a number and try to hit my range");
            var userNumber = int.Parse(Console.ReadLine());

            if (userNumber >= -10 && userNumber<=10) 
            {
                Console.WriteLine("Darn! You got me!!");
            }
            else
            {
                Console.WriteLine("Better luck next time");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void TimeToTimes()
        {
            Console.WriteLine("I'm a multiplication master, give me a number between 1 and 12:");
            var magicNumber = int.Parse(Console.ReadLine());

            int[] multNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            foreach (int multNumber in multNumbers)
            {
                Console.WriteLine($"{magicNumber} x {multNumber} = {magicNumber*multNumber}");
                
            }

        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //All methods commented out intentionally
            
            //ReverseNumbers();
            //ByThrees();
            //EqualOrNot();
            //OddOrEven();
           // PosOrNeg();
          // VoterEligible();
          // FindMyRange();
         // TimeToTimes();


        }
    }
}
