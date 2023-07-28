namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Printnum1000() 
        {
            for (int i = 1000; i >= -1000; i--) 
            { 
              Console.WriteLine(i); 
            }
        
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void UpByThrees() 
        {
            for (int i = 3; i <= 999; i += 3) 
            { 
             Console.WriteLine(i);
            
            }

        
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool TwoNumsSame(int num1, int num2) 
        {
            if (num1 == num2)
            {
                return true;
            }
            else 
            { 
              return false;
            
            }
        
        
        
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenorOdd(int num) 
        
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num}is even");
            }
            else 
            { 
                Console.WriteLine($"{num} is odd");
            
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static bool IsPostive(int num) 
        {
            if (num > 0)
            {
                return true;
            }
            else 
            { 
                return false;   
            }
              






        }
            

            
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void CanVote() 
        { 
         Console.WriteLine("Please enter your age; ");
         var canParse =int.TryParse(Console.ReadLine(), out int age);
            Console.WriteLine(age);
            
        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool IsInTenRange(int num) 
        {
            if (num <= 10 && num >= -10)

            {

                return true;
            }
            else 
            {
                return false;
            }
        
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplyThru12(int num) 
        {
            for (int i = 0; i <= 12; i++) 
            {
              Console.WriteLine($"{num} * {i} = {num * i}");
            
            }
        
        
        
        }
            
       
        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Printnum1000();
            UpByThrees();
            bool numsSame = TwoNumsSame (2, 2);
            EvenorOdd(2);
            var isPostive = IsPostive(11);
            CanVote();
            Console.WriteLine("Moving on ..");

            bool tenRange = IsInTenRange(9);
            Console.WriteLine(tenRange);

            MultiplyThru12(12);
        }
 
            
          
        
            
            
            
        
        
        

       
            
                
        
        
        

    }
}
