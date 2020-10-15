using System;

namespace PowersTable2
{
    class Program
    {
        static void Main(string[] args)

        {
            bool manySquares = true;
            while (manySquares)
            {
                Console.WriteLine("Please enter an integer.");                
                string userInput = Console.ReadLine();
               /* while (true)
                {
                    string userNumber;
                    if (int.TryParse(userInput, out userNumber))
                    { Console.WriteLine($"Your number is: {userNumber}"); }
                    else
                    break;
                    { Console.WriteLine("This is not a number!"); }
                break;
                }*/
                
               
                int number = int.Parse(userInput);
                int counter = 0;
                int square = number * number;
                int cube = number * number * number;

              

                while (counter <= number)
                
                {
                    Console.WriteLine(counter);
                    counter++;
                    Console.WriteLine(square);
                    square++;

                    Console.WriteLine(cube);

                    Console.WriteLine("Number      Square         Cube");
                    Console.WriteLine("----------------------------------");

                    for (counter = 1; counter <= number; counter++)
                    {
                        square = counter * counter;
                        cube = counter * counter * counter;
                        Console.WriteLine("{0}            {1}             {2}   ", counter, square, cube);
                    }



                    Console.WriteLine("Would you like to continue?y/n");
                    string yesNo = Console.ReadLine();
                    if (yesNo == "y")
                    {
                        Console.WriteLine("Let's use a different number this time.");
                        manySquares = true;

                    }

                    else
                    {
                        Console.WriteLine("Goodbye.");
                        manySquares = false;

                    }
                }




            }
        }
    }
}

