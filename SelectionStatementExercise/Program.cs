namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           //EXERCISE 1
            var favNumber = 150;
            //var favNumber = r.Next(1, 200);
            Console.WriteLine("Enter a number between 1 and 200 to guess my fave number :)");
            var userInput = int.Parse(Console.ReadLine());


            if (userInput < favNumber)
            {
                Console.WriteLine("Good guess but not quite! Too low.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Sorry buddy not quite. Too high.");
            }
            else
            {
                Console.WriteLine("Way to go! You've got it!");
            }


        }
    }
}
